namespace Bezpieczny_Notatnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ICON = new PictureBox();
            panelTitle = new Panel();
            btnMini = new PictureBox();
            btnZamknij = new PictureBox();
            panel1 = new Panel();
            panelGlowny = new Panel();
            ((System.ComponentModel.ISupportInitialize)ICON).BeginInit();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnZamknij).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ICON
            // 
            resources.ApplyResources(ICON, "ICON");
            ICON.Name = "ICON";
            ICON.TabStop = false;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(227, 203, 227);
            panelTitle.Controls.Add(btnMini);
            panelTitle.Controls.Add(btnZamknij);
            panelTitle.Controls.Add(ICON);
            resources.ApplyResources(panelTitle, "panelTitle");
            panelTitle.Name = "panelTitle";
            // 
            // btnMini
            // 
            resources.ApplyResources(btnMini, "btnMini");
            btnMini.Name = "btnMini";
            btnMini.TabStop = false;
            btnMini.Click += btnMini_Click_1;
            // 
            // btnZamknij
            // 
            resources.ApplyResources(btnZamknij, "btnZamknij");
            btnZamknij.Name = "btnZamknij";
            btnZamknij.TabStop = false;
            btnZamknij.Click += btnZamknij_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 252, 244);
            panel1.Controls.Add(panelGlowny);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // panelGlowny
            // 
            resources.ApplyResources(panelGlowny, "panelGlowny");
            panelGlowny.Name = "panelGlowny";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 203, 227);
            Controls.Add(panelTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)ICON).EndInit();
            panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMini).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnZamknij).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ICON;
        private Panel panelTitle;
        private Panel panel1;
        private Panel panelGlowny;
        private PictureBox btnMini;
        private PictureBox btnZamknij;
    }
}
