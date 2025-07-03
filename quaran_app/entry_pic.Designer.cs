namespace quaran_app
{
    partial class entry_pic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(entry_pic));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox2).BeginInit();
            SuspendLayout();
            // 
            // guna2CirclePictureBox2
            // 
            guna2CirclePictureBox2.BackColor = Color.Transparent;
            guna2CirclePictureBox2.FillColor = Color.PapayaWhip;
            guna2CirclePictureBox2.Image = (Image)resources.GetObject("guna2CirclePictureBox2.Image");
            guna2CirclePictureBox2.ImageRotate = 0F;
            guna2CirclePictureBox2.Location = new Point(235, 26);
            guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            guna2CirclePictureBox2.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox2.Size = new Size(712, 563);
            guna2CirclePictureBox2.TabIndex = 1;
            guna2CirclePictureBox2.TabStop = false;
            guna2CirclePictureBox2.Click += guna2CirclePictureBox2_Click;
            // 
            // entry_pic
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1207, 761);
            Controls.Add(guna2CirclePictureBox2);
            Name = "entry_pic";
            Text = "entry_pic";
            Load += entry_pic_Load_1;
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
    }
}