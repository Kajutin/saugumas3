namespace Sifravimas
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
            this.LibraryEncryptButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FileDecryptButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LibraryEncodedTextBox = new System.Windows.Forms.TextBox();
            this.LibraryDecryptButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LibraryRawTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LibraryEncryptButton
            // 
            this.LibraryEncryptButton.Location = new System.Drawing.Point(320, 202);
            this.LibraryEncryptButton.Name = "LibraryEncryptButton";
            this.LibraryEncryptButton.Size = new System.Drawing.Size(55, 23);
            this.LibraryEncryptButton.TabIndex = 1;
            this.LibraryEncryptButton.Text = "Encrypt";
            this.LibraryEncryptButton.UseVisualStyleBackColor = true;
            this.LibraryEncryptButton.Click += new System.EventHandler(this.LibraryEncryptButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FileDecryptButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LibraryDecryptButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.LibraryEncryptButton);
            this.panel1.Location = new System.Drawing.Point(8, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 426);
            this.panel1.TabIndex = 2;
            // 
            // FileDecryptButton
            // 
            this.FileDecryptButton.Location = new System.Drawing.Point(14, 202);
            this.FileDecryptButton.Name = "FileDecryptButton";
            this.FileDecryptButton.Size = new System.Drawing.Size(94, 23);
            this.FileDecryptButton.TabIndex = 8;
            this.FileDecryptButton.Text = "Decrypt from File";
            this.FileDecryptButton.UseVisualStyleBackColor = true;
            this.FileDecryptButton.Click += new System.EventHandler(this.FileDecryptButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.LibraryEncodedTextBox);
            this.panel2.Location = new System.Drawing.Point(14, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 174);
            this.panel2.TabIndex = 7;
            // 
            // LibraryEncodedTextBox
            // 
            this.LibraryEncodedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LibraryEncodedTextBox.Location = new System.Drawing.Point(3, 3);
            this.LibraryEncodedTextBox.Multiline = true;
            this.LibraryEncodedTextBox.Name = "LibraryEncodedTextBox";
            this.LibraryEncodedTextBox.Size = new System.Drawing.Size(417, 174);
            this.LibraryEncodedTextBox.TabIndex = 3;
            this.LibraryEncodedTextBox.Text = "ENCRYPTED TEXT GOES HERE";
            // 
            // LibraryDecryptButton
            // 
            this.LibraryDecryptButton.Location = new System.Drawing.Point(381, 202);
            this.LibraryDecryptButton.Name = "LibraryDecryptButton";
            this.LibraryDecryptButton.Size = new System.Drawing.Size(55, 23);
            this.LibraryDecryptButton.TabIndex = 6;
            this.LibraryDecryptButton.Text = "Decrypt";
            this.LibraryDecryptButton.UseVisualStyleBackColor = true;
            this.LibraryDecryptButton.Click += new System.EventHandler(this.LibraryDecryptButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.LibraryRawTextBox);
            this.panel3.Location = new System.Drawing.Point(14, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(427, 184);
            this.panel3.TabIndex = 2;
            // 
            // LibraryRawTextBox
            // 
            this.LibraryRawTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LibraryRawTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibraryRawTextBox.Location = new System.Drawing.Point(3, 3);
            this.LibraryRawTextBox.Multiline = true;
            this.LibraryRawTextBox.Name = "LibraryRawTextBox";
            this.LibraryRawTextBox.Size = new System.Drawing.Size(417, 174);
            this.LibraryRawTextBox.TabIndex = 4;
            this.LibraryRawTextBox.Text = "TEXT TO ENCRYPT GOES HERE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 456);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LibraryEncryptButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox LibraryEncodedTextBox;
        private System.Windows.Forms.TextBox LibraryRawTextBox;
        private System.Windows.Forms.Button LibraryDecryptButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button FileDecryptButton;
    }
}

