
namespace _4915M_Lab
{
    partial class Menu
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
            this.Lab1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Lab2b = new System.Windows.Forms.Button();
            this.Lab2c = new System.Windows.Forms.Button();
            this.Lab3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lab1
            // 
            this.Lab1.Location = new System.Drawing.Point(44, 65);
            this.Lab1.Name = "Lab1";
            this.Lab1.Size = new System.Drawing.Size(83, 37);
            this.Lab1.TabIndex = 0;
            this.Lab1.Text = "Lab1";
            this.Lab1.UseVisualStyleBackColor = true;
            this.Lab1.Click += new System.EventHandler(this.Lab1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lab2a";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lab2b
            // 
            this.Lab2b.Location = new System.Drawing.Point(44, 151);
            this.Lab2b.Name = "Lab2b";
            this.Lab2b.Size = new System.Drawing.Size(83, 37);
            this.Lab2b.TabIndex = 2;
            this.Lab2b.Text = "Lab2b";
            this.Lab2b.UseVisualStyleBackColor = true;
            this.Lab2b.Click += new System.EventHandler(this.Lab2b_Click);
            // 
            // Lab2c
            // 
            this.Lab2c.Location = new System.Drawing.Point(44, 194);
            this.Lab2c.Name = "Lab2c";
            this.Lab2c.Size = new System.Drawing.Size(83, 37);
            this.Lab2c.TabIndex = 3;
            this.Lab2c.Text = "Lab2c";
            this.Lab2c.UseVisualStyleBackColor = true;
            this.Lab2c.Click += new System.EventHandler(this.Lab2c_Click);
            // 
            // Lab3
            // 
            this.Lab3.Location = new System.Drawing.Point(44, 237);
            this.Lab3.Name = "Lab3";
            this.Lab3.Size = new System.Drawing.Size(83, 37);
            this.Lab3.TabIndex = 4;
            this.Lab3.Text = "Lab3";
            this.Lab3.UseVisualStyleBackColor = true;
            this.Lab3.Click += new System.EventHandler(this.Lab3_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lab3);
            this.Controls.Add(this.Lab2c);
            this.Controls.Add(this.Lab2b);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lab1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Lab1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Lab2b;
        private System.Windows.Forms.Button Lab2c;
        private System.Windows.Forms.Button Lab3;
    }
}