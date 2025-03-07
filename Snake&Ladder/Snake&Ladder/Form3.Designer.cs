namespace Snake_Ladder
{
    partial class Intro
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSTART = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Snake_Ladder.Properties.Resources.bg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(951, 779);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSTART
            // 
            this.btnSTART.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSTART.BackColor = System.Drawing.Color.Blue;
            this.btnSTART.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSTART.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTART.Location = new System.Drawing.Point(352, 625);
            this.btnSTART.Name = "btnSTART";
            this.btnSTART.Size = new System.Drawing.Size(243, 79);
            this.btnSTART.TabIndex = 1;
            this.btnSTART.Text = "START";
            this.btnSTART.UseVisualStyleBackColor = false;
            this.btnSTART.Click += new System.EventHandler(this.btnSTART_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEXIT.BackColor = System.Drawing.Color.Red;
            this.btnEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEXIT.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXIT.Location = new System.Drawing.Point(416, 710);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(115, 44);
            this.btnEXIT.TabIndex = 2;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = false;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 776);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnSTART);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSTART;
        private System.Windows.Forms.Button btnEXIT;
    }
}