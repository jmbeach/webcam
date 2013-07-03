namespace Webcam
{
    partial class WebcamMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.systray = new System.Windows.Forms.NotifyIcon(this.components);
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.previewBoxContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.filterAuswählenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schwarzWeißToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gespiegeltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drehenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.previewBoxContext.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // systray
            // 
            this.systray.Text = "notifyIcon1";
            this.systray.Visible = true;
            // 
            // previewBox
            // 
            this.previewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewBox.ContextMenuStrip = this.previewBoxContext;
            this.previewBox.Location = new System.Drawing.Point(0, 27);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(662, 447);
            this.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewBox.TabIndex = 0;
            this.previewBox.TabStop = false;
            // 
            // previewBoxContext
            // 
            this.previewBoxContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterAuswählenToolStripMenuItem1,
            this.speichernToolStripMenuItem});
            this.previewBoxContext.Name = "previewBoxContext";
            this.previewBoxContext.Size = new System.Drawing.Size(160, 70);
            this.previewBoxContext.Text = "Test";
            // 
            // filterAuswählenToolStripMenuItem1
            // 
            this.filterAuswählenToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sepiaToolStripMenuItem,
            this.negativToolStripMenuItem,
            this.schwarzWeißToolStripMenuItem,
            this.gespiegeltToolStripMenuItem,
            this.drehenToolStripMenuItem});
            this.filterAuswählenToolStripMenuItem1.Name = "filterAuswählenToolStripMenuItem1";
            this.filterAuswählenToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.filterAuswählenToolStripMenuItem1.Text = "Filter auswählen";
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            // 
            // schwarzWeißToolStripMenuItem
            // 
            this.schwarzWeißToolStripMenuItem.Name = "schwarzWeißToolStripMenuItem";
            this.schwarzWeißToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.schwarzWeißToolStripMenuItem.Text = "Schwarz Weiß";
            // 
            // gespiegeltToolStripMenuItem
            // 
            this.gespiegeltToolStripMenuItem.Name = "gespiegeltToolStripMenuItem";
            this.gespiegeltToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gespiegeltToolStripMenuItem.Text = "Gespiegelt";
            // 
            // drehenToolStripMenuItem
            // 
            this.drehenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.drehenToolStripMenuItem.Name = "drehenToolStripMenuItem";
            this.drehenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.drehenToolStripMenuItem.Text = "Drehen";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem2.Text = "90°";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem3.Text = "180 °";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem4.Text = "270 °";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem5.Text = "0°";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speichernToolStripMenuItem1,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "&Datei";
            // 
            // speichernToolStripMenuItem1
            // 
            this.speichernToolStripMenuItem1.Name = "speichernToolStripMenuItem1";
            this.speichernToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.speichernToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.speichernToolStripMenuItem1.Text = "Speichern";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.beendenToolStripMenuItem.Text = "&Beenden";
            // 
            // negativToolStripMenuItem
            // 
            this.negativToolStripMenuItem.Name = "negativToolStripMenuItem";
            this.negativToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.negativToolStripMenuItem.Text = "Negativ";
            // 
            // WebcamMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 474);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WebcamMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webcam - Mirko Düßeldorf";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WebcamMain_FormClosed);
            this.Load += new System.EventHandler(this.WebcamMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.previewBoxContext.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon systray;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip previewBoxContext;
        private System.Windows.Forms.ToolStripMenuItem filterAuswählenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schwarzWeißToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gespiegeltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drehenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem negativToolStripMenuItem;
    }
}

