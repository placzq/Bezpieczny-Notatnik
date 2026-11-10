namespace Bezpieczny_Notatnik
{
    partial class Dashboard
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menu = new Panel();
            btnSettings = new PictureBox();
            btnNotes = new PictureBox();
            btnDashboard = new PictureBox();
            btnNowaNotatka = new Button();
            pictureBox1 = new PictureBox();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(249, 244, 249);
            menu.Controls.Add(btnSettings);
            menu.Controls.Add(btnNotes);
            menu.Controls.Add(btnDashboard);
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(106, 500);
            menu.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.BackgroundImageLayout = ImageLayout.None;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.Location = new Point(30, 180);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(46, 50);
            btnSettings.SizeMode = PictureBoxSizeMode.Zoom;
            btnSettings.TabIndex = 2;
            btnSettings.TabStop = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnNotes
            // 
            btnNotes.Image = (Image)resources.GetObject("btnNotes.Image");
            btnNotes.Location = new Point(30, 109);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(46, 44);
            btnNotes.SizeMode = PictureBoxSizeMode.Zoom;
            btnNotes.TabIndex = 1;
            btnNotes.TabStop = false;
            btnNotes.Click += btnNotes_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.Location = new Point(30, 32);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(46, 50);
            btnDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            btnDashboard.TabIndex = 0;
            btnDashboard.TabStop = false;
            // 
            // btnNowaNotatka
            // 
            btnNowaNotatka.BackColor = Color.FromArgb(254, 236, 165);
            btnNowaNotatka.FlatAppearance.BorderSize = 0;
            btnNowaNotatka.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 151, 196);
            btnNowaNotatka.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 218, 136);
            btnNowaNotatka.FlatStyle = FlatStyle.Flat;
            btnNowaNotatka.Font = new Font("Patrick Hand", 18F, FontStyle.Bold);
            btnNowaNotatka.ForeColor = Color.FromArgb(57, 36, 72);
            btnNowaNotatka.ImeMode = ImeMode.NoControl;
            btnNowaNotatka.Location = new Point(547, 32);
            btnNowaNotatka.Name = "btnNowaNotatka";
            btnNowaNotatka.Size = new Size(220, 65);
            btnNowaNotatka.TabIndex = 18;
            btnNowaNotatka.Text = "Nowa notatka";
            btnNowaNotatka.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(173, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(498, 477);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnNowaNotatka);
            Controls.Add(pictureBox1);
            Controls.Add(menu);
            Name = "Dashboard";
            Size = new Size(800, 500);
            menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNotes).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menu;
        private Button btnNowaNotatka;
        private PictureBox btnSettings;
        private PictureBox btnNotes;
        private PictureBox btnDashboard;
        private PictureBox pictureBox1;
    }
}
