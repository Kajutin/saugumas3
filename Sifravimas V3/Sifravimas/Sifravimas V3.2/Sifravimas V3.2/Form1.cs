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

namespace Sifravimas_V3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LibraryRawTextBox.MaxLength = 58;
            //
            // RSA nepalaiko ilgo teksto, tada jau reikia kombinuoti su DES ar AES sifrais, jei nori ilgesnio
            //

        }
        #region Kintamieji
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        string pub;
        string _privateKeyXML;
        string _publicKeyXml;
        byte[] plaintext;
        byte[] encryptedtext;
        string Path;
        Dictionary<string, string> keyDictionary = new Dictionary<string, string>();
        #endregion Kintamieji

        //
        // DECRYPT MYGTUKAS
        //
        private void LibraryDecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                // KOKIA TVARKA REIKIA UZKODUOTI BYTES, KAD TEISINGAI VISA INFORMACIJA PERSIDUOTU:
                //
                // abc
                Encoding.UTF8.GetBytes
                // 13 31 32
                Convert.ToBase64String;
                // saf
                Convert.FromBase64String;
                // 13 31 32
                Encoding.UTF8.GetString;
                // abc
                */
                byte[] inputBytes;
                var encryptedBytes = Convert.FromBase64String(LibraryEncodedTextBox.Text);
                using (var rsaClient = new RSACryptoServiceProvider(2048))
                {
                    //
                    // PADUODU PRIVATE KEY IR ATSIFRUOJU
                    //
                    rsaClient.FromXmlString(_privateKeyXML);
                    inputBytes = rsaClient.Decrypt(encryptedBytes, false);
                }
                string output = Encoding.UTF8.GetString(inputBytes);
                LibraryRawTextBox.Text = output;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("Encryption failed.");
            }
        }

        //
        // SIFRAVIMO MYGTUKAS
        //
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var rsaServer = new RSACryptoServiceProvider(2048))
                {
                    _privateKeyXML = rsaServer.ToXmlString(true);
                    _publicKeyXml = rsaServer.ToXmlString(false);
                }

                //
                // UZSIFRUOJA
                //
                string tempString = LibraryRawTextBox.Text;
                var inputBytes = Encoding.UTF8.GetBytes(tempString);
                byte[] encryptedBytes = null;
                using (var rsaClient = new RSACryptoServiceProvider(2048))
                {
                    rsaClient.FromXmlString(_publicKeyXml);
                    encryptedBytes = rsaClient.Encrypt(inputBytes, false);
                    using (var sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "txt files (*.txt)|*.txt";
                        sfd.RestoreDirectory = true;
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            //
                            // ISSAUGOJAMI BYTES I FILE, tarpinis zingsnis, tiesiog kodavimo eigoje taip patogiau buvo bytes perduoti
                            //
                            Path = sfd.FileName;
                            File.WriteAllBytes(Path, encryptedBytes);
                            LibraryEncodedTextBox.Text = Convert.ToBase64String(File.ReadAllBytes(Path));
                            //
                            // DICTIONARY tam, kad issaugomas file ir atsifravimui skirtas private key
                            //
                            keyDictionary.Add(_privateKeyXML, LibraryEncodedTextBox.Text);
                            //
                            // IRASOMA I FILE DICTIONARY TURINYS, jo mums reikes atsifruoti is failo, jei noresime
                            //
                            using (StreamWriter file = new StreamWriter(Path))
                                foreach (var entry in keyDictionary)
                                    file.WriteLine("{0} {1}", entry.Key, entry.Value);
                        }
                    }
                }


                // 
                // UZSAUGOMAS PUBLIC KEY I FAILA
                //
                using (StreamWriter writer = new StreamWriter("C:\\Users\\kajus\\Desktop\\saugumas\\test Praktinis 3\\publicKey.txt"))
                {
                    writer.Write(_publicKeyXml);
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Encryption failed.");
            }
        }

        //
        // DECRYPT IS FAILO, persikeliant i .net core su pavadinimais kylo problemu
        //
        private void button3_Click(object sender, EventArgs e)
        {
            var content = string.Empty; ;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "txt files (*.txt)|*.txt";
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //
                    // UZPILDOME DICTIONARY
                    //
                    Path = ofd.FileName;
                    keyDictionary.Clear();
                    string temp1;
                    StreamReader sr = new StreamReader(Path);
                    while ((temp1 = sr.ReadLine()) != null)
                    {
                        //
                        // temp2 = private key
                        // temp3 = uzkoduotas turinys
                        //
                        string temp2 = temp1.Substring(0, temp1.IndexOf(" "));
                        string temp3 = temp1.Substring(temp1.IndexOf(" ") + 1);

                        keyDictionary.Add(temp2, temp3);
                    }
                }
            }
            try
            {
                //
                // PADUODU FAILO INFORMACIJA
                // PRIVATUS RAKTAS (desifravimui)  --  UZSIFRUOTAS TURINYS
                // PAVERCIU IS BASE64 KODUOTES I BYTES ATGAL TURINI
                // VISKA PADUODU UZSIFRUOTI
                //
                string tempKey = keyDictionary.Keys.First();
                byte[] inputBytes;
                string tempValue = keyDictionary.Values.First();
                byte[] tempValueBytes = Convert.FromBase64String(tempValue);
                using (var rsaClient = new RSACryptoServiceProvider(2048))
                {
                    rsaClient.FromXmlString(tempKey);
                    inputBytes = rsaClient.Decrypt(tempValueBytes, false);
                }
                LibraryRawTextBox.Text = Encoding.UTF8.GetString(inputBytes);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("Encryption failed.");
            }
        }
    }
}
