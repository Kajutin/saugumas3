
namespace Sifravimas_V3._2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LibraryRawTextBox = new System.Windows.Forms.TextBox();
            this.LibraryEncodedTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LibraryDecryptButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LibraryRawTextBox
            // 
            this.LibraryRawTextBox.Location = new System.Drawing.Point(12, 12);
            this.LibraryRawTextBox.Multiline = true;
            this.LibraryRawTextBox.Name = "LibraryRawTextBox";
            this.LibraryRawTextBox.Size = new System.Drawing.Size(301, 138);
            this.LibraryRawTextBox.TabIndex = 0;
            this.LibraryRawTextBox.Text = "TEXT TO ENCRYPT GOES HERE";
            // 
            // LibraryEncodedTextBox
            // 
            this.LibraryEncodedTextBox.Location = new System.Drawing.Point(335, 12);
            this.LibraryEncodedTextBox.Multiline = true;
            this.LibraryEncodedTextBox.Name = "LibraryEncodedTextBox";
            this.LibraryEncodedTextBox.Size = new System.Drawing.Size(301, 138);
            this.LibraryEncodedTextBox.TabIndex = 1;
            this.LibraryEncodedTextBox.Text = "ENCRYPTED TEXT GOES HERE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LibraryDecryptButton
            // 
            this.LibraryDecryptButton.Location = new System.Drawing.Point(335, 156);
            this.LibraryDecryptButton.Name = "LibraryDecryptButton";
            this.LibraryDecryptButton.Size = new System.Drawing.Size(95, 23);
            this.LibraryDecryptButton.TabIndex = 3;
            this.LibraryDecryptButton.Text = "Decrypt";
            this.LibraryDecryptButton.UseVisualStyleBackColor = true;
            this.LibraryDecryptButton.Click += new System.EventHandler(this.LibraryDecryptButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(524, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Decrypt from file";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 203);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LibraryDecryptButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LibraryEncodedTextBox);
            this.Controls.Add(this.LibraryRawTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LibraryRawTextBox;
        private System.Windows.Forms.TextBox LibraryEncodedTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button FileDecryptButton;
        private System.Windows.Forms.Button LibraryDecryptButton;
        private System.Windows.Forms.Button button3;
    }
}