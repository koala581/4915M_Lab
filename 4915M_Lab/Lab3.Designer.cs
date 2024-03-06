
namespace _4915M_Lab
{
    partial class Lab3
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
            this.btnCast = new System.Windows.Forms.Button();
            this.lblCast = new System.Windows.Forms.Label();
            this.cboMovie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCast
            // 
            this.btnCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCast.Location = new System.Drawing.Point(328, 348);
            this.btnCast.Name = "btnCast";
            this.btnCast.Size = new System.Drawing.Size(145, 35);
            this.btnCast.TabIndex = 0;
            this.btnCast.Text = "Cast your vote";
            this.btnCast.UseVisualStyleBackColor = true;
            this.btnCast.Click += new System.EventHandler(this.btnCast_Click);
            // 
            // lblCast
            // 
            this.lblCast.AutoSize = true;
            this.lblCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCast.Location = new System.Drawing.Point(284, 31);
            this.lblCast.Name = "lblCast";
            this.lblCast.Size = new System.Drawing.Size(275, 24);
            this.lblCast.TabIndex = 1;
            this.lblCast.Text = "My Choice of Best Movie Series";
            // 
            // cboMovie
            // 
            this.cboMovie.FormattingEnabled = true;
            this.cboMovie.Items.AddRange(new object[] {
            "The Godfather",
            "Terminator",
            "Back to the Future",
            "Martrix"});
            this.cboMovie.Location = new System.Drawing.Point(308, 174);
            this.cboMovie.Name = "cboMovie";
            this.cboMovie.Size = new System.Drawing.Size(192, 21);
            this.cboMovie.TabIndex = 2;
            this.cboMovie.SelectedIndexChanged += new System.EventHandler(this.cboMovie_SelectedIndexChanged);
            // 
            // Lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboMovie);
            this.Controls.Add(this.lblCast);
            this.Controls.Add(this.btnCast);
            this.Name = "Lab3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCast;
        private System.Windows.Forms.Label lblCast;
        private System.Windows.Forms.ComboBox cboMovie;
    }
}