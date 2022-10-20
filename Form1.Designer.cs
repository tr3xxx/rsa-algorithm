namespace WindowsFormsApp1
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.encryptInput = new System.Windows.Forms.TextBox();
            this.decryptInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.InputD = new System.Windows.Forms.NumericUpDown();
            this.InputN = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.outputEncrypt = new System.Windows.Forms.TextBox();
            this.outputDecrypted = new System.Windows.Forms.TextBox();
            this.DisplayPrivateKey = new System.Windows.Forms.TextBox();
            this.CopyEncryptedOutput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InputD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSA-Algorithmus";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // encryptInput
            // 
            this.encryptInput.AllowDrop = true;
            this.encryptInput.ImeMode = System.Windows.Forms.ImeMode.On;
            this.encryptInput.Location = new System.Drawing.Point(85, 138);
            this.encryptInput.Multiline = true;
            this.encryptInput.Name = "encryptInput";
            this.encryptInput.Size = new System.Drawing.Size(210, 105);
            this.encryptInput.TabIndex = 5;
            // 
            // decryptInput
            // 
            this.decryptInput.Location = new System.Drawing.Point(483, 138);
            this.decryptInput.Multiline = true;
            this.decryptInput.Name = "decryptInput";
            this.decryptInput.Size = new System.Drawing.Size(210, 105);
            this.decryptInput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Verschlüsseln";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Entschlüsseln";
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(136, 307);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(94, 20);
            this.encrypt.TabIndex = 9;
            this.encrypt.Text = "Verschlüsseln";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(546, 307);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(94, 20);
            this.decrypt.TabIndex = 10;
            this.decrypt.Text = "Entschlüsseln";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // InputD
            // 
            this.InputD.Location = new System.Drawing.Point(583, 250);
            this.InputD.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.InputD.Name = "InputD";
            this.InputD.Size = new System.Drawing.Size(110, 20);
            this.InputD.TabIndex = 11;
            // 
            // InputN
            // 
            this.InputN.Location = new System.Drawing.Point(583, 273);
            this.InputN.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.InputN.Name = "InputN";
            this.InputN.Size = new System.Drawing.Size(110, 20);
            this.InputN.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Private Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "D:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "N:";
            // 
            // outputEncrypt
            // 
            this.outputEncrypt.BackColor = System.Drawing.SystemColors.Control;
            this.outputEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputEncrypt.ImeMode = System.Windows.Forms.ImeMode.On;
            this.outputEncrypt.Location = new System.Drawing.Point(85, 333);
            this.outputEncrypt.Multiline = true;
            this.outputEncrypt.Name = "outputEncrypt";
            this.outputEncrypt.ReadOnly = true;
            this.outputEncrypt.Size = new System.Drawing.Size(210, 105);
            this.outputEncrypt.TabIndex = 20;
            this.outputEncrypt.Visible = false;
            // 
            // outputDecrypted
            // 
            this.outputDecrypted.BackColor = System.Drawing.SystemColors.Control;
            this.outputDecrypted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputDecrypted.ImeMode = System.Windows.Forms.ImeMode.On;
            this.outputDecrypted.Location = new System.Drawing.Point(486, 333);
            this.outputDecrypted.Multiline = true;
            this.outputDecrypted.Name = "outputDecrypted";
            this.outputDecrypted.ReadOnly = true;
            this.outputDecrypted.Size = new System.Drawing.Size(210, 105);
            this.outputDecrypted.TabIndex = 21;
            this.outputDecrypted.Visible = false;
            // 
            // DisplayPrivateKey
            // 
            this.DisplayPrivateKey.BackColor = System.Drawing.SystemColors.Control;
            this.DisplayPrivateKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisplayPrivateKey.ImeMode = System.Windows.Forms.ImeMode.On;
            this.DisplayPrivateKey.Location = new System.Drawing.Point(85, 249);
            this.DisplayPrivateKey.Multiline = true;
            this.DisplayPrivateKey.Name = "DisplayPrivateKey";
            this.DisplayPrivateKey.ReadOnly = true;
            this.DisplayPrivateKey.Size = new System.Drawing.Size(210, 27);
            this.DisplayPrivateKey.TabIndex = 22;
            this.DisplayPrivateKey.Visible = false;
            // 
            // CopyEncryptedOutput
            // 
            this.CopyEncryptedOutput.Location = new System.Drawing.Point(136, 458);
            this.CopyEncryptedOutput.Name = "CopyEncryptedOutput";
            this.CopyEncryptedOutput.Size = new System.Drawing.Size(94, 20);
            this.CopyEncryptedOutput.TabIndex = 23;
            this.CopyEncryptedOutput.Text = "Kopieren";
            this.CopyEncryptedOutput.UseVisualStyleBackColor = true;
            this.CopyEncryptedOutput.Visible = false;
            this.CopyEncryptedOutput.Click += new System.EventHandler(this.CopyEncryptedOutput_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(797, 521);
            this.Controls.Add(this.CopyEncryptedOutput);
            this.Controls.Add(this.DisplayPrivateKey);
            this.Controls.Add(this.outputDecrypted);
            this.Controls.Add(this.outputEncrypt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InputN);
            this.Controls.Add(this.InputD);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.decryptInput);
            this.Controls.Add(this.encryptInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox encryptInput;
        private System.Windows.Forms.TextBox decryptInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.NumericUpDown InputD;
        private System.Windows.Forms.NumericUpDown InputN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox outputEncrypt;
        private System.Windows.Forms.TextBox outputDecrypted;
        private System.Windows.Forms.TextBox DisplayPrivateKey;
        private System.Windows.Forms.Button CopyEncryptedOutput;
    }
}

