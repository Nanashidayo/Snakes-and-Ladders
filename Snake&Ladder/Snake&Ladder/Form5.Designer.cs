namespace Snake_Ladder
{
    partial class AI2Ps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AI2Ps));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picBoxT1 = new System.Windows.Forms.PictureBox();
            this.picBoxT2 = new System.Windows.Forms.PictureBox();
            this.picBoxDie = new System.Windows.Forms.PictureBox();
            this.picBoxChar2 = new System.Windows.Forms.PictureBox();
            this.picBoxChar1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 818);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.BackColor = System.Drawing.Color.Magenta;
            this.lblTurn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTurn.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(787, 431);
            this.lblTurn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(138, 33);
            this.lblTurn.TabIndex = 28;
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName2
            // 
            this.lblName2.BackColor = System.Drawing.Color.Lime;
            this.lblName2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblName2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName2.Location = new System.Drawing.Point(820, 259);
            this.lblName2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(73, 33);
            this.lblName2.TabIndex = 27;
            this.lblName2.Text = "Midori";
            this.lblName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName1
            // 
            this.lblName1.BackColor = System.Drawing.Color.Pink;
            this.lblName1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblName1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName1.Location = new System.Drawing.Point(820, 112);
            this.lblName1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(73, 33);
            this.lblName1.TabIndex = 26;
            this.lblName1.Text = "Momoi";
            this.lblName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoll
            // 
            this.lblRoll.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblRoll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRoll.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll.Location = new System.Drawing.Point(820, 501);
            this.lblRoll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(73, 26);
            this.lblRoll.TabIndex = 25;
            this.lblRoll.Text = "ROLLED:";
            this.lblRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(820, 740);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(74, 29);
            this.exit.TabIndex = 21;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRoll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoll.Font = new System.Drawing.Font("OCR A Extended", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(787, 611);
            this.btnRoll.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(138, 54);
            this.btnRoll.TabIndex = 20;
            this.btnRoll.Text = "ROLL";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // picBoxT1
            // 
            this.picBoxT1.Image = global::Snake_Ladder.Properties.Resources.Momoi_Halo;
            this.picBoxT1.Location = new System.Drawing.Point(22, 751);
            this.picBoxT1.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxT1.Name = "picBoxT1";
            this.picBoxT1.Size = new System.Drawing.Size(40, 40);
            this.picBoxT1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxT1.TabIndex = 29;
            this.picBoxT1.TabStop = false;
            // 
            // picBoxT2
            // 
            this.picBoxT2.Image = global::Snake_Ladder.Properties.Resources.Midori_Halo;
            this.picBoxT2.Location = new System.Drawing.Point(21, 751);
            this.picBoxT2.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxT2.Name = "picBoxT2";
            this.picBoxT2.Size = new System.Drawing.Size(40, 40);
            this.picBoxT2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxT2.TabIndex = 30;
            this.picBoxT2.TabStop = false;
            // 
            // picBoxDie
            // 
            this.picBoxDie.Location = new System.Drawing.Point(820, 529);
            this.picBoxDie.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxDie.Name = "picBoxDie";
            this.picBoxDie.Size = new System.Drawing.Size(74, 67);
            this.picBoxDie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDie.TabIndex = 24;
            this.picBoxDie.TabStop = false;
            // 
            // picBoxChar2
            // 
            this.picBoxChar2.Image = global::Snake_Ladder.Properties.Resources.Midori_Halo;
            this.picBoxChar2.Location = new System.Drawing.Point(814, 294);
            this.picBoxChar2.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxChar2.Name = "picBoxChar2";
            this.picBoxChar2.Size = new System.Drawing.Size(86, 86);
            this.picBoxChar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxChar2.TabIndex = 23;
            this.picBoxChar2.TabStop = false;
            // 
            // picBoxChar1
            // 
            this.picBoxChar1.BackColor = System.Drawing.Color.Transparent;
            this.picBoxChar1.Image = global::Snake_Ladder.Properties.Resources.Momoi_Halo;
            this.picBoxChar1.Location = new System.Drawing.Point(814, 148);
            this.picBoxChar1.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxChar1.Name = "picBoxChar1";
            this.picBoxChar1.Size = new System.Drawing.Size(86, 86);
            this.picBoxChar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxChar1.TabIndex = 22;
            this.picBoxChar1.TabStop = false;
            this.picBoxChar1.Click += new System.EventHandler(this.picBoxChar1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(753, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(211, 813);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // AI2Ps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 815);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.lblRoll);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.picBoxT1);
            this.Controls.Add(this.picBoxT2);
            this.Controls.Add(this.picBoxDie);
            this.Controls.Add(this.picBoxChar2);
            this.Controls.Add(this.picBoxChar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AI2Ps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.AI2Ps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picBoxT1;
        private System.Windows.Forms.PictureBox picBoxT2;
        private System.Windows.Forms.PictureBox picBoxDie;
        private System.Windows.Forms.PictureBox picBoxChar2;
        private System.Windows.Forms.PictureBox picBoxChar1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}