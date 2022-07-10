namespace WebBrowser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnback = new System.Windows.Forms.ToolStripButton();
            this.btnforward = new System.Windows.Forms.ToolStripButton();
            this.btnrefresh = new System.Windows.Forms.ToolStripButton();
            this.btnaddtab = new System.Windows.Forms.ToolStripButton();
            this.btndeltab = new System.Windows.Forms.ToolStripButton();
            this.txturl = new System.Windows.Forms.ToolStripTextBox();
            this.btnsearch = new System.Windows.Forms.ToolStripButton();
            this.btnhome = new System.Windows.Forms.ToolStripButton();
            this.btnfav = new System.Windows.Forms.ToolStripButton();
            this.cmbfav = new System.Windows.Forms.ToolStripComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndelfav = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowItemReorder = true;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnback,
            this.btnforward,
            this.btnrefresh,
            this.btnaddtab,
            this.btndeltab,
            this.txturl,
            this.btnsearch,
            this.btnhome,
            this.btnfav,
            this.btndelfav,
            this.cmbfav});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1047, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnback
            // 
            this.btnback.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(23, 24);
            this.btnback.Text = "toolStripButton1";
            this.btnback.ToolTipText = "Back";
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnforward
            // 
            this.btnforward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnforward.Image = ((System.Drawing.Image)(resources.GetObject("btnforward.Image")));
            this.btnforward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnforward.Name = "btnforward";
            this.btnforward.Size = new System.Drawing.Size(23, 24);
            this.btnforward.Text = "toolStripButton2";
            this.btnforward.ToolTipText = "Forward";
            this.btnforward.Click += new System.EventHandler(this.btnforward_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Image")));
            this.btnrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(23, 24);
            this.btnrefresh.Text = "toolStripButton3";
            this.btnrefresh.ToolTipText = "Refresh";
            // 
            // btnaddtab
            // 
            this.btnaddtab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnaddtab.Image = ((System.Drawing.Image)(resources.GetObject("btnaddtab.Image")));
            this.btnaddtab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnaddtab.Name = "btnaddtab";
            this.btnaddtab.Size = new System.Drawing.Size(23, 24);
            this.btnaddtab.Text = "New Tab";
            this.btnaddtab.Click += new System.EventHandler(this.btnaddtab_Click);
            // 
            // btndeltab
            // 
            this.btndeltab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btndeltab.Image = ((System.Drawing.Image)(resources.GetObject("btndeltab.Image")));
            this.btndeltab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndeltab.Name = "btndeltab";
            this.btndeltab.Size = new System.Drawing.Size(23, 24);
            this.btndeltab.Text = "Del Tab";
            this.btndeltab.Click += new System.EventHandler(this.btndeltab_Click);
            // 
            // txturl
            // 
            this.txturl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(500, 27);
            this.txturl.Enter += new System.EventHandler(this.txturl_Enter);
            this.txturl.Click += new System.EventHandler(this.txturl_Click);
            this.txturl.DoubleClick += new System.EventHandler(this.txturl_DoubleClick);
            // 
            // btnsearch
            // 
            this.btnsearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(23, 24);
            this.btnsearch.Text = "toolStripButton1";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnhome
            // 
            this.btnhome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(23, 24);
            this.btnhome.Text = "toolStripButton4";
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnfav
            // 
            this.btnfav.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnfav.Image = ((System.Drawing.Image)(resources.GetObject("btnfav.Image")));
            this.btnfav.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnfav.Name = "btnfav";
            this.btnfav.Size = new System.Drawing.Size(23, 24);
            this.btnfav.Text = "Add Current Page to Favorites";
            this.btnfav.Click += new System.EventHandler(this.btnfav_Click);
            // 
            // cmbfav
            // 
            this.cmbfav.AutoToolTip = true;
            this.cmbfav.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfav.Name = "cmbfav";
            this.cmbfav.Size = new System.Drawing.Size(370, 23);
            this.cmbfav.ToolTipText = "Lista de Favoritos";
            this.cmbfav.Click += new System.EventHandler(this.cmbfav_Click);
            this.cmbfav.TextChanged += new System.EventHandler(this.cmbfav_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1047, 384);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1039, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Tab";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 384);
            this.panel1.TabIndex = 5;
            // 
            // btndelfav
            // 
            this.btndelfav.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btndelfav.Image = ((System.Drawing.Image)(resources.GetObject("btndelfav.Image")));
            this.btndelfav.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndelfav.Name = "btndelfav";
            this.btndelfav.Size = new System.Drawing.Size(23, 24);
            this.btndelfav.Text = "Delete From Favorite";
            this.btndelfav.Click += new System.EventHandler(this.btndelfav_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Browser Buret";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnback;
        private System.Windows.Forms.ToolStripButton btnforward;
        private System.Windows.Forms.ToolStripButton btnrefresh;
        private System.Windows.Forms.ToolStripTextBox txturl;
        private System.Windows.Forms.ToolStripButton btnsearch;
        private System.Windows.Forms.ToolStripButton btnhome;
        private System.Windows.Forms.ToolStripButton btnfav;
        private System.Windows.Forms.ToolStripComboBox cmbfav;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripButton btnaddtab;
        private System.Windows.Forms.ToolStripButton btndeltab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btndelfav;
    }
}

