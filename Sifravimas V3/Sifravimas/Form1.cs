using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using System.Runtime;
namespace Sifravimas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LibraryRawTextBox.MaxLength = 58;

        }
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] plaintext;
        byte[] encryptedtext;
        private void LibraryEncryptButton_Click(object sender, EventArgs e)
        {
            #region Kintamieji
            string Path = null; //= @"C:\Users\kajus\Desktop\testSaugumas\b.txt"; // deklaruoju cia, kad galeciau lengviau keisti jei noreciau
            #endregion Kintamieji
            try
            {
                plaintext = ByteConverter.GetBytes(LibraryRawTextBox.Text);
                encryptedtext = Encryption(plaintext, RSA.ExportParameters(false), false);
                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "txt files (*.txt)|*.txt";
                    sfd.RestoreDirectory = true;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Path = sfd.FileName;
                    }
                }
                using (StreamWriter writer = new StreamWriter(Path))
                {
                    writer.Write(ByteConverter.GetString(encryptedtext));
                }
                LibraryEncodedTextBox.Text = ByteConverter.GetString(encryptedtext);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Encryption failed.");
            }
        }
        private void LibraryDecryptButton_Click(object sender, EventArgs e)
        {
            #region Kintamieji
            string Path = @"C:\Users\kajus\Desktop\testSaugumas\b.txt"; // deklaruoju cia, kad galeciau lengviau keisti jei 
            #endregion Kintamieji
                //byte[] temp_Data = Convert.FromBase64String(LibraryEncodedTextBox.Text);
            try
            {
                byte[] decryptedtex = Decryption(encryptedtext,
                RSA.ExportParameters(true), false);
                LibraryRawTextBox.Text = ByteConverter.GetString(decryptedtex);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("Encryption failed.");
            }
        }
        private void FileDecryptButton_Click(object sender, EventArgs e)
        {

            #region Kintamieji
            var content = string.Empty;;
            using (OpenFileDialog ofd = new OpenFileDialog())
            { 
                string path;
                ofd.Filter = "txt files (*.txt)|*.txt";
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                    var data = ofd.OpenFile();
                    using (StreamReader sr = new StreamReader(data))
                    {
                        content = sr.ReadToEnd();
                    }
                }
            }
            try
            {
                
                byte[] decryptedtex = Decryption(ByteConverter.GetBytes(content),
                RSA.ExportParameters(true), false);
                LibraryRawTextBox.Text = ByteConverter.GetString(decryptedtex);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("Encryption failed.");
            }
            #endregion Kintamieji
        }
        static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}




