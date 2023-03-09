namespace EMOJI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            i00SpellCheck.SpellCheckSettings spellCheckSettings1 = new i00SpellCheck.SpellCheckSettings();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EMOJIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.IDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.PropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TurnOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.RtbeEditor = new RichTextBoxEx.RichTextBoxEx();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Panel1.SuspendLayout();
            this.ContextMenuStrip1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.ContextMenuStrip = this.ContextMenuStrip1;
            this.Panel1.Controls.Add(this.Button4);
            this.Panel1.Controls.Add(this.Button3);
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(800, 100);
            this.Panel1.TabIndex = 0;
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EMOJIToolStripMenuItem,
            this.toolStripSeparator2,
            this.IDEToolStripMenuItem,
            this.toolStripSeparator3,
            this.PropertiesToolStripMenuItem,
            this.toolStripSeparator4,
            this.TurnOffToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(128, 110);
            // 
            // EMOJIToolStripMenuItem
            // 
            this.EMOJIToolStripMenuItem.Image = global::EMOJI.Properties.Resources.Emoji;
            this.EMOJIToolStripMenuItem.Name = "EMOJIToolStripMenuItem";
            this.EMOJIToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.EMOJIToolStripMenuItem.Text = "EMOJI";
            this.EMOJIToolStripMenuItem.ToolTipText = "EMOJI";
            this.EMOJIToolStripMenuItem.Click += new System.EventHandler(this.EMOJIToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(124, 6);
            // 
            // IDEToolStripMenuItem
            // 
            this.IDEToolStripMenuItem.Image = global::EMOJI.Properties.Resources.CS;
            this.IDEToolStripMenuItem.Name = "IDEToolStripMenuItem";
            this.IDEToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.IDEToolStripMenuItem.Text = "IDE";
            this.IDEToolStripMenuItem.ToolTipText = "IDE";
            this.IDEToolStripMenuItem.Click += new System.EventHandler(this.IDEToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(124, 6);
            // 
            // PropertiesToolStripMenuItem
            // 
            this.PropertiesToolStripMenuItem.Image = global::EMOJI.Properties.Resources.Properties;
            this.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem";
            this.PropertiesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.PropertiesToolStripMenuItem.Text = "Properties";
            this.PropertiesToolStripMenuItem.ToolTipText = "Properties";
            this.PropertiesToolStripMenuItem.Click += new System.EventHandler(this.PropertiesToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(124, 6);
            // 
            // TurnOffToolStripMenuItem
            // 
            this.TurnOffToolStripMenuItem.Image = global::EMOJI.Properties.Resources.Turn_off;
            this.TurnOffToolStripMenuItem.Name = "TurnOffToolStripMenuItem";
            this.TurnOffToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.TurnOffToolStripMenuItem.Text = "Turn off";
            this.TurnOffToolStripMenuItem.ToolTipText = "Turn off";
            this.TurnOffToolStripMenuItem.Click += new System.EventHandler(this.TurnOffToolStripMenuItem_Click);
            // 
            // Button4
            // 
            this.Button4.BackgroundImage = global::EMOJI.Properties.Resources.CS;
            this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button4.Location = new System.Drawing.Point(300, 0);
            this.Button4.Margin = new System.Windows.Forms.Padding(0);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(100, 100);
            this.Button4.TabIndex = 3;
            this.ToolTip1.SetToolTip(this.Button4, "IDE");
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.BackgroundImage = global::EMOJI.Properties.Resources.CS;
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button3.Location = new System.Drawing.Point(200, 0);
            this.Button3.Margin = new System.Windows.Forms.Padding(0);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(100, 100);
            this.Button3.TabIndex = 2;
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.BackgroundImage = global::EMOJI.Properties.Resources.CS;
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Location = new System.Drawing.Point(100, 0);
            this.Button2.Margin = new System.Windows.Forms.Padding(0);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(100, 100);
            this.Button2.TabIndex = 1;
            this.ToolTip1.SetToolTip(this.Button2, "IDE");
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.BackgroundImage = global::EMOJI.Properties.Resources.Emoji;
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Location = new System.Drawing.Point(0, 0);
            this.Button1.Margin = new System.Windows.Forms.Padding(0);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(100, 100);
            this.Button1.TabIndex = 0;
            this.ToolTip1.SetToolTip(this.Button1, "EMOJI");
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.RtbeEditor);
            this.Panel2.Controls.Add(this.ToolStrip1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(0, 100);
            this.Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(800, 350);
            this.Panel2.TabIndex = 1;
            // 
            // RtbeEditor
            // 
            this.RtbeEditor.AllowDefaultInsertText = true;
            this.RtbeEditor.AllowDefaultSmartText = true;
            this.RtbeEditor.AllowDrop = true;
            this.RtbeEditor.AllowHyphenation = true;
            this.RtbeEditor.AllowLists = true;
            this.RtbeEditor.AllowPageAndLineBreaks = true;
            this.RtbeEditor.AllowPictures = true;
            this.RtbeEditor.AllowSpellCheck = true;
            this.RtbeEditor.AllowSymbols = true;
            this.RtbeEditor.AllowTabs = true;
            this.RtbeEditor.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.RtbeEditor.AvailableListStyle = ((RichTextBoxEx.ListStyleCollection)(resources.GetObject("RtbeEditor.AvailableListStyle")));
            this.RtbeEditor.BackColor = System.Drawing.Color.GhostWhite;
            this.RtbeEditor.CustomContextMenuArray = new System.Windows.Forms.ToolStripItem[] {
        ((System.Windows.Forms.ToolStripItem)(this.ToolStripMenuItem1)),
        ((System.Windows.Forms.ToolStripItem)(this.toolStripSeparator5))};
            this.RtbeEditor.CustomToolstripArray = new System.Windows.Forms.ToolStripItem[0];
            this.RtbeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtbeEditor.DoCustomLinks = true;
            this.RtbeEditor.FilePath = "";
            this.RtbeEditor.InferURLScheme = true;
            this.RtbeEditor.IsSpellCheckContinuous = true;
            this.RtbeEditor.IsTextChanged = true;
            this.RtbeEditor.KeepHypertextOnRemove = false;
            this.RtbeEditor.Location = new System.Drawing.Point(0, 25);
            this.RtbeEditor.MaintainSelection = false;
            this.RtbeEditor.Margin = new System.Windows.Forms.Padding(0);
            this.RtbeEditor.Name = "RtbeEditor";
            this.RtbeEditor.RightMargin = 886;
            this.RtbeEditor.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Calibri;}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs23\\par" +
    "\r\n}\r\n";
            this.RtbeEditor.SetColorWithFont = true;
            this.RtbeEditor.ShowPageBreaks = true;
            this.RtbeEditor.ShowRuler = true;
            this.RtbeEditor.ShowToolStrip = true;
            this.RtbeEditor.Size = new System.Drawing.Size(800, 325);
            this.RtbeEditor.SkipLinksOnReplace = true;
            spellCheckSettings1.AllowF7 = false;
            spellCheckSettings1.IgnoreWordsInUpperCase = false;
            this.RtbeEditor.SpellCheckSettings = spellCheckSettings1;
            this.RtbeEditor.TabIndex = 10;
            this.RtbeEditor.UnitsForRuler = RichTextBoxEx.TextRuler.UnitType.Inches;
            this.RtbeEditor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RtbeEditor_MouseDown);
            this.RtbeEditor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RtbeEditor_MouseMove);
            this.RtbeEditor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RtbeEditor_MouseUp);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Image = global::EMOJI.Properties.Resources.Properties;
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.ToolStripMenuItem1.Text = "Properties";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.PropertiesToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(213, 6);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(800, 25);
            this.ToolStrip1.TabIndex = 0;
            this.ToolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.ContextMenuStrip1;
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EMOJI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel1.ResumeLayout(false);
            this.ContextMenuStrip1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TurnOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.ToolStripMenuItem EMOJIToolStripMenuItem;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.ToolStripMenuItem IDEToolStripMenuItem;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button3;
        public RichTextBoxEx.RichTextBoxEx RtbeEditor;
        private System.Windows.Forms.ToolStripMenuItem PropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

