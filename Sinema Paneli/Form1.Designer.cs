namespace Sinema_Paneli
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSec = new Button();
            btnSil = new Button();
            SuspendLayout();
            // 
            // btnSec
            // 
            btnSec.Font = new Font("Verdana", 30F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSec.Location = new Point(580, 12);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(150, 130);
            btnSec.TabIndex = 0;
            btnSec.Text = "Kaydet";
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Verdana", 30F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(580, 152);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(150, 130);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 303);
            Controls.Add(btnSil);
            Controls.Add(btnSec);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSec;
        private Button btnSil;
    }
}
