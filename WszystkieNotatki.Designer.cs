namespace Bezpieczny_Notatnik
{
    partial class WszystkieNotatki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WszystkieNotatki));
            menu = new Panel();
            btnSettings = new PictureBox();
            btnNotes = new PictureBox();
            btnDashboard = new PictureBox();
            panelWszystkichNotatek = new FlowLayoutPanel();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDashboard).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Anchor = AnchorStyles.None;
            menu.BackColor = Color.FromArgb(249, 244, 249);
            menu.Controls.Add(btnSettings);
            menu.Controls.Add(btnNotes);
            menu.Controls.Add(btnDashboard);
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(106, 500);
            menu.TabIndex = 1;
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
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelWszystkichNotatek
            // 
            panelWszystkichNotatek.AutoScroll = true;
            panelWszystkichNotatek.Location = new Point(142, 109);
            panelWszystkichNotatek.Name = "panelWszystkichNotatek";
            panelWszystkichNotatek.Size = new Size(625, 361);
            panelWszystkichNotatek.TabIndex = 2;
            // 
            // WszystkieNotatki
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelWszystkichNotatek);
            Controls.Add(menu);
            Name = "WszystkieNotatki";
            Size = new Size(800, 500);
            menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNotes).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDashboard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menu;
        private PictureBox btnSettings;
        private PictureBox btnNotes;
        private PictureBox btnDashboard;
        private FlowLayoutPanel panelWszystkichNotatek;
    }
}
