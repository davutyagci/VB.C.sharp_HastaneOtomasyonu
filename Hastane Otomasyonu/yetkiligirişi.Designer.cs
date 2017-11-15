namespace Hastane_Otomasyonu
{
    partial class yetkiligirişi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yetkiligirişi));
            this.Button1 = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.Location = new System.Drawing.Point(215, 22);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(53, 53);
            this.Button1.TabIndex = 15;
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(66, 74);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 14;
            this.PictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Label1.Location = new System.Drawing.Point(107, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(82, 21);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Yetkili Kodu";
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBox1.Location = new System.Drawing.Point(98, 46);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '♣';
            this.TextBox1.Size = new System.Drawing.Size(100, 29);
            this.TextBox1.TabIndex = 12;
            this.TextBox1.Tag = "";
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // yetkiligirişi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 99);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBox1);
            this.Name = "yetkiligirişi";
            this.Text = "yetkiligirişi";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}