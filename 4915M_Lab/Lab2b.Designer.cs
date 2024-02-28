
namespace _4915M_Lab
{
    partial class Lab2b
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab2b));
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.radioRainy = new System.Windows.Forms.RadioButton();
            this.radioSnowy = new System.Windows.Forms.RadioButton();
            this.radioSunny = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picCloudy = new System.Windows.Forms.PictureBox();
            this.picRainy = new System.Windows.Forms.PictureBox();
            this.picSunny = new System.Windows.Forms.PictureBox();
            this.picSnowy = new System.Windows.Forms.PictureBox();
            this.radioCloudy = new System.Windows.Forms.RadioButton();
            this.lblMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloudy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRainy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSunny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnowy)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(38, 49);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(233, 29);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Enter your name here: ";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(297, 49);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(367, 28);
            this.textBoxName.TabIndex = 1;
            // 
            // radioRainy
            // 
            this.radioRainy.AutoSize = true;
            this.radioRainy.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRainy.Location = new System.Drawing.Point(47, 56);
            this.radioRainy.Name = "radioRainy";
            this.radioRainy.Size = new System.Drawing.Size(69, 27);
            this.radioRainy.TabIndex = 3;
            this.radioRainy.TabStop = true;
            this.radioRainy.Text = "&Rainy";
            this.radioRainy.UseVisualStyleBackColor = true;
            this.radioRainy.CheckedChanged += new System.EventHandler(this.radioRainy_CheckedChanged);
            // 
            // radioSnowy
            // 
            this.radioSnowy.AutoSize = true;
            this.radioSnowy.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSnowy.Location = new System.Drawing.Point(47, 89);
            this.radioSnowy.Name = "radioSnowy";
            this.radioSnowy.Size = new System.Drawing.Size(75, 27);
            this.radioSnowy.TabIndex = 4;
            this.radioSnowy.TabStop = true;
            this.radioSnowy.Text = "&Snowy";
            this.radioSnowy.UseVisualStyleBackColor = true;
            this.radioSnowy.CheckedChanged += new System.EventHandler(this.radioSnowy_CheckedChanged);
            // 
            // radioSunny
            // 
            this.radioSunny.AutoSize = true;
            this.radioSunny.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSunny.Location = new System.Drawing.Point(47, 122);
            this.radioSunny.Name = "radioSunny";
            this.radioSunny.Size = new System.Drawing.Size(72, 27);
            this.radioSunny.TabIndex = 5;
            this.radioSunny.TabStop = true;
            this.radioSunny.Text = "&Sunny";
            this.radioSunny.UseVisualStyleBackColor = true;
            this.radioSunny.CheckedChanged += new System.EventHandler(this.radioSunny_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCloudy);
            this.groupBox1.Controls.Add(this.radioSunny);
            this.groupBox1.Controls.Add(this.radioSnowy);
            this.groupBox1.Controls.Add(this.radioRainy);
            this.groupBox1.Location = new System.Drawing.Point(43, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 171);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // picCloudy
            // 
            this.picCloudy.Image = ((System.Drawing.Image)(resources.GetObject("picCloudy.Image")));
            this.picCloudy.Location = new System.Drawing.Point(382, 186);
            this.picCloudy.Name = "picCloudy";
            this.picCloudy.Size = new System.Drawing.Size(64, 64);
            this.picCloudy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCloudy.TabIndex = 7;
            this.picCloudy.TabStop = false;
            this.picCloudy.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picRainy
            // 
            this.picRainy.Image = ((System.Drawing.Image)(resources.GetObject("picRainy.Image")));
            this.picRainy.Location = new System.Drawing.Point(473, 186);
            this.picRainy.Name = "picRainy";
            this.picRainy.Size = new System.Drawing.Size(64, 64);
            this.picRainy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRainy.TabIndex = 8;
            this.picRainy.TabStop = false;
            // 
            // picSunny
            // 
            this.picSunny.Image = ((System.Drawing.Image)(resources.GetObject("picSunny.Image")));
            this.picSunny.Location = new System.Drawing.Point(473, 265);
            this.picSunny.Name = "picSunny";
            this.picSunny.Size = new System.Drawing.Size(64, 64);
            this.picSunny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSunny.TabIndex = 9;
            this.picSunny.TabStop = false;
            // 
            // picSnowy
            // 
            this.picSnowy.Image = ((System.Drawing.Image)(resources.GetObject("picSnowy.Image")));
            this.picSnowy.Location = new System.Drawing.Point(382, 265);
            this.picSnowy.Name = "picSnowy";
            this.picSnowy.Size = new System.Drawing.Size(64, 64);
            this.picSnowy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSnowy.TabIndex = 10;
            this.picSnowy.TabStop = false;
            // 
            // radioCloudy
            // 
            this.radioCloudy.AutoSize = true;
            this.radioCloudy.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCloudy.Location = new System.Drawing.Point(47, 23);
            this.radioCloudy.Name = "radioCloudy";
            this.radioCloudy.Size = new System.Drawing.Size(77, 27);
            this.radioCloudy.TabIndex = 6;
            this.radioCloudy.TabStop = true;
            this.radioCloudy.Text = "&Cloudy";
            this.radioCloudy.UseVisualStyleBackColor = true;
            this.radioCloudy.CheckedChanged += new System.EventHandler(this.radioCloudy_CheckedChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(101, 387);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(585, 33);
            this.lblMessage.TabIndex = 11;
            // 
            // Lab2b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.picSnowy);
            this.Controls.Add(this.picSunny);
            this.Controls.Add(this.picRainy);
            this.Controls.Add(this.picCloudy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "Lab2b";
            this.Text = "Weather Report";
            this.Load += new System.EventHandler(this.Lab2b_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloudy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRainy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSunny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnowy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RadioButton radioRainy;
        private System.Windows.Forms.RadioButton radioSnowy;
        private System.Windows.Forms.RadioButton radioSunny;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picCloudy;
        private System.Windows.Forms.PictureBox picRainy;
        private System.Windows.Forms.PictureBox picSunny;
        private System.Windows.Forms.PictureBox picSnowy;
        private System.Windows.Forms.RadioButton radioCloudy;
        private System.Windows.Forms.Label lblMessage;
    }
}