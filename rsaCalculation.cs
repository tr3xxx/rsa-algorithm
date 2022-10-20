using System;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;

public class rsaCalculation
{
    public static char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    public static string[] Encrypt(string text)
    {
        long[] pubkey = calc_publickey();
        long[] privkey = calc_privatekey(pubkey);
        return new string[] { encryption(text.ToLower().ToCharArray(), pubkey), format_key(privkey) };
    }
    private static string format_key(long[] key)
    {
        return "Privater Schlüssel: (" + key[0].ToString() + "/" + key[1].ToString() + ")";
    }
    public static string Decrypt(string text, long[] privatkey)
    {
        return decryption(text.ToLower().ToCharArray(), privatkey);
    }
    private static string decryption(char[] text, long[] privatkey)
    {
        char[] decryptedText = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Equals(' '))
                decryptedText[i] = ' ';
            else
                decryptedText[i] = alphabet[(Array.IndexOf(alphabet, text[i]) ^ privatkey[0]) % 26];
        }
        return new string(decryptedText);


    }
    private static string encryption(char[] text, long[] publickey)
    {
        Console.WriteLine(publickey[0]+"/"+publickey[1]);
        char[] encryptedText = new char[text.Length];
        
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Equals(' '))
                encryptedText[i] = text[i];
            else 
                 encryptedText[i] = alphabet[(Array.IndexOf(alphabet, text[i]) ^ publickey[1] % publickey[0]) % 26];
        }
        return new string(encryptedText);
    }
    private static long[] calc_privatekey(long[] publickey)
    {
        return new long[2] { calc_d(publickey), publickey[2] };
    }

    private static long calc_d(long[] publickey) // calculates d (multiplikatives inverse)
    {
        if (simple_euclidean_algorithm(publickey))
         return advanced_euclidean_algorithm(publickey[0], publickey[2]);
          
        else
        {
            return -1; // error
        }
    }
    private static long advanced_euclidean_algorithm(long a,long b) // calculates advanced ea
    {
        return multiplicative_iverse(a, b);
        
    }
    private static long multiplicative_iverse(long a,long b)
    {
        long m0 = b;
        long y = 0, x = 1;

        if (b == 1)
            return 0;

        while (b > 1)
        {
            long q = a / b;

            long t = b;

            
            b = a % b;
            a = t;
            t = y;

            
            y = x - q * y;
            x = t;
        }
       
        if (x < 0)
            x += m0;

        
        return x;
    }
    

    private static bool simple_euclidean_algorithm(long[] publickey) // calculates simple ea 
    {
        if (ggT(publickey[0], publickey[2]) == 1)
            return true;
        return false;
    }
    private static long ggT(long a,long b) => a == 0 ? b : ggT(b % a, a); // calculates biggest shared divider

    private static long[] calc_publickey() // calculates public key
    {
        long[] pq = calc_pq();
        long n = calc_n(pq);
        long phi_n = calc_phifunc(pq);
        long e = calc_e(phi_n);

        return new long[3] { e, n, phi_n}; // phi_n is in public key cause its justed again later, not actually part of public key tho
            
    }
    private static long calc_e(long phi_n)
    {
        long e = LongRandom(1, phi_n, new Random());
        while (true)
        {
            if (ggT(e, phi_n) == 1)
                return e;
            e++;
        }
    }
    private static long calc_phifunc(long[] pq) // calculates phi function 
    {

        return (pq[0] - 1) * (pq[1] - 1);
    }
    private static long[] calc_pq() // calculate p and q;
    {
        long p = GetPrimeNumber(LongRandom(10000000, 90000000, new Random()));
        long q = GetPrimeNumber(LongRandom(10000000, 90000000, new Random()));
        if (p == q)
        {
            return calc_pq();
            
        }
        return new long[2] { p, q };
  
    }
    private static long calc_n(long[] pq) // calculate n;
    {
        return pq[0] * pq[1];
    }
    
	private static long GetPrimeNumber(long number) // searches for prime number
    {

        while (true)
        {
            if (IsPrimeNumber(number)){

                return number;
            }
            else
            {
                number++;
            }
        }
    } 
    
    public static bool IsPrimeNumber(long number) // checks if a number is a prime number 
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (long)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }
    private static long LongRandom(long min, long max, Random rand) // generates long random n
    {
        byte[] buf = new byte[8];
        rand.NextBytes(buf);
        long longRand = BitConverter.ToInt64(buf, 0);

        return (Math.Abs(longRand % (max - min)) + min);
    }
}

