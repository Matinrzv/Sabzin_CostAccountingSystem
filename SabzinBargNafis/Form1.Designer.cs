namespace SabzinBargNafis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTarkib = new System.Windows.Forms.Button();
            this.btnBahaieTamamshode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 722);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(529, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 116);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(1007, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "آدرس:";
            // 
            // btnTarkib
            // 
            this.btnTarkib.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnTarkib.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTarkib.Location = new System.Drawing.Point(811, 116);
            this.btnTarkib.Name = "btnTarkib";
            this.btnTarkib.Size = new System.Drawing.Size(128, 51);
            this.btnTarkib.TabIndex = 3;
            this.btnTarkib.Text = "بخش ترکیب";
            this.btnTarkib.UseVisualStyleBackColor = true;
            this.btnTarkib.Click += new System.EventHandler(this.btnTarkib_Click);
            // 
            // btnBahaieTamamshode
            // 
            this.btnBahaieTamamshode.Font = new System.Drawing.Font("B Titr", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBahaieTamamshode.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBahaieTamamshode.Location = new System.Drawing.Point(811, 198);
            this.btnBahaieTamamshode.Name = "btnBahaieTamamshode";
            this.btnBahaieTamamshode.Size = new System.Drawing.Size(128, 51);
            this.btnBahaieTamamshode.TabIndex = 4;
            this.btnBahaieTamamshode.Text = "بخش بهای تمام شده";
            this.btnBahaieTamamshode.UseVisualStyleBackColor = true;
            this.btnBahaieTamamshode.Click += new System.EventHandler(this.btnBahaieTamamshode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1090, 739);
            this.Controls.Add(this.btnBahaieTamamshode);
            this.Controls.Add(this.btnTarkib);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("B Badr", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محاسبه بهای تمام شده";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTarkib;
        private System.Windows.Forms.Button btnBahaieTamamshode;
    }
}

