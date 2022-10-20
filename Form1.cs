using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
           
        }

   

        private void decrypt_Click(object sender, EventArgs e)
        {
            if (InputD.Value == 0 || InputN.Value == 0)
            {
                MessageBox.Show("Der eingegebene Schlüssel ist ungültig!");
            }
            else
            {
                string decrypted = rsaCalculation.Decrypt(decryptInput.Text, new long[] { long.Parse(InputD.Value.ToString()), long.Parse(InputN.Value.ToString()) });
                outputDecrypted.Visible = true;
                outputDecrypted.Text = decrypted;
            }
        }
        private void encrypt_Click(object sender, EventArgs e)
        {
            // check if input is valid, only letters and spaces
            if (System.Text.RegularExpressions.Regex.IsMatch(encryptInput.Text, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Bitte benutze ausschliesslich Buchstaben (A-Z) und Leerzeichen");
                return;
            }
            else
            {
                string[] encypted = rsaCalculation.Encrypt(encryptInput.Text);

                outputEncrypt.Visible = true;
                outputEncrypt.Text = encypted[0];

                DisplayPrivateKey.Visible = true;
                DisplayPrivateKey.Text = encypted[1];

                CopyEncryptedOutput.Visible = true;

            }


        }
        

        private void CopyEncryptedOutput_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputEncrypt.Text);
        }

        
        
    }
}
