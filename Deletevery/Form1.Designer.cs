namespace Deletevery
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slctfile = new System.Windows.Forms.ToolStripMenuItem();
            this.slctfolder = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.wutaboutmen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnstart = new System.Windows.Forms.Button();
            this.lblintro = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slctfile,
            this.slctfolder,
            this.exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // slctfile
            // 
            this.slctfile.Name = "slctfile";
            this.slctfile.Size = new System.Drawing.Size(180, 22);
            this.slctfile.Text = "Select File";
            this.slctfile.Click += new System.EventHandler(this.selectFileToolStripMenuItem_Click);
            // 
            // slctfolder
            // 
            this.slctfolder.Name = "slctfolder";
            this.slctfolder.Size = new System.Drawing.Size(180, 22);
            this.slctfolder.Text = "Select Folder";
            this.slctfolder.Click += new System.EventHandler(this.slctfolder_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(180, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help,
            this.wutaboutmen});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // help
            // 
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(180, 22);
            this.help.Text = "Help";
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // wutaboutmen
            // 
            this.wutaboutmen.Name = "wutaboutmen";
            this.wutaboutmen.Size = new System.Drawing.Size(180, 22);
            this.wutaboutmen.Text = "About";
            this.wutaboutmen.Click += new System.EventHandler(this.wutaboutmen_Click);
            // 
            // btnstart
            // 
            this.btnstart.AutoSize = true;
            this.btnstart.Location = new System.Drawing.Point(376, 413);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(80, 26);
            this.btnstart.TabIndex = 2;
            this.btnstart.Text = "START";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // lblintro
            // 
            this.lblintro.AutoSize = true;
            this.lblintro.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblintro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblintro.Location = new System.Drawing.Point(21, 134);
            this.lblintro.Name = "lblintro";
            this.lblintro.Size = new System.Drawing.Size(758, 156);
            this.lblintro.TabIndex = 4;
            this.lblintro.Text = "WARNING:  Bro and sis, this application is dangerous \r\nbecause removed file won\'t" +
    " be back. \r\nTherefore, while you are using program, \r\nbe careful.\r\n";
            this.lblintro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.lblintro);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DeletEvery";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slctfile;
        private System.Windows.Forms.ToolStripMenuItem slctfolder;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem wutaboutmen;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label lblintro;
    }
}

