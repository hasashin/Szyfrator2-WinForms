namespace Szyfrator_2
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szyfrogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szyfrogramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DecipherButton = new System.Windows.Forms.Button();
            this.DecipherKeyTextBox = new System.Windows.Forms.TextBox();
            this.CipheredInputTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RawOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CipherButton = new System.Windows.Forms.Button();
            this.CipherKeyTextBox = new System.Windows.Forms.TextBox();
            this.RawInputTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CipheredOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tekstToolStripMenuItem,
            this.szyfrogramToolStripMenuItem});
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz...";
            // 
            // tekstToolStripMenuItem
            // 
            this.tekstToolStripMenuItem.Name = "tekstToolStripMenuItem";
            this.tekstToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.tekstToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tekstToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.tekstToolStripMenuItem.Text = "Tekst";
            this.tekstToolStripMenuItem.Click += new System.EventHandler(this.tekstToolStripMenuItem_Click);
            // 
            // szyfrogramToolStripMenuItem
            // 
            this.szyfrogramToolStripMenuItem.Name = "szyfrogramToolStripMenuItem";
            this.szyfrogramToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.szyfrogramToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.szyfrogramToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.szyfrogramToolStripMenuItem.Text = "Szyfrogram";
            this.szyfrogramToolStripMenuItem.Click += new System.EventHandler(this.szyfrogramToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szyfrogramToolStripMenuItem1,
            this.tekstToolStripMenuItem1});
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // szyfrogramToolStripMenuItem1
            // 
            this.szyfrogramToolStripMenuItem1.Name = "szyfrogramToolStripMenuItem1";
            this.szyfrogramToolStripMenuItem1.ShortcutKeyDisplayString = "";
            this.szyfrogramToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.szyfrogramToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.szyfrogramToolStripMenuItem1.Text = "Szyfrogram";
            this.szyfrogramToolStripMenuItem1.Click += new System.EventHandler(this.szyfrogramToolStripMenuItem1_Click);
            // 
            // tekstToolStripMenuItem1
            // 
            this.tekstToolStripMenuItem1.Name = "tekstToolStripMenuItem1";
            this.tekstToolStripMenuItem1.ShortcutKeyDisplayString = "";
            this.tekstToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tekstToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.tekstToolStripMenuItem1.Text = "Tekst";
            this.tekstToolStripMenuItem1.Click += new System.EventHandler(this.tekstToolStripMenuItem1_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(426, 411);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Odszyfrowanie";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.DecipherButton);
            this.panel2.Controls.Add(this.DecipherKeyTextBox);
            this.panel2.Controls.Add(this.CipheredInputTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 199);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Klucz deszyfrujący:";
            // 
            // DecipherButton
            // 
            this.DecipherButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DecipherButton.Enabled = false;
            this.DecipherButton.Location = new System.Drawing.Point(330, 173);
            this.DecipherButton.Name = "DecipherButton";
            this.DecipherButton.Size = new System.Drawing.Size(81, 23);
            this.DecipherButton.TabIndex = 3;
            this.DecipherButton.Text = "Odszyfruj";
            this.DecipherButton.UseVisualStyleBackColor = true;
            this.DecipherButton.Click += new System.EventHandler(this.DecipherButton_Click);
            // 
            // DecipherKeyTextBox
            // 
            this.DecipherKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecipherKeyTextBox.Location = new System.Drawing.Point(106, 175);
            this.DecipherKeyTextBox.Name = "DecipherKeyTextBox";
            this.DecipherKeyTextBox.Size = new System.Drawing.Size(218, 20);
            this.DecipherKeyTextBox.TabIndex = 2;
            this.DecipherKeyTextBox.TextChanged += new System.EventHandler(this.CipherKeyTextBox_TextChanged);
            // 
            // CipheredInputTextBox
            // 
            this.CipheredInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CipheredInputTextBox.Location = new System.Drawing.Point(3, 16);
            this.CipheredInputTextBox.Name = "CipheredInputTextBox";
            this.CipheredInputTextBox.Size = new System.Drawing.Size(408, 151);
            this.CipheredInputTextBox.TabIndex = 0;
            this.CipheredInputTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tekst do odszyfrowania:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.RawOutputTextBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 194);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wynik:";
            // 
            // RawOutputTextBox
            // 
            this.RawOutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RawOutputTextBox.Location = new System.Drawing.Point(3, 16);
            this.RawOutputTextBox.Name = "RawOutputTextBox";
            this.RawOutputTextBox.ReadOnly = true;
            this.RawOutputTextBox.Size = new System.Drawing.Size(408, 175);
            this.RawOutputTextBox.TabIndex = 0;
            this.RawOutputTextBox.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Szyfrowanie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CipherButton);
            this.panel1.Controls.Add(this.CipherKeyTextBox);
            this.panel1.Controls.Add(this.RawInputTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 199);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Klucz szyfrujący:";
            // 
            // CipherButton
            // 
            this.CipherButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CipherButton.Enabled = false;
            this.CipherButton.Location = new System.Drawing.Point(330, 173);
            this.CipherButton.Name = "CipherButton";
            this.CipherButton.Size = new System.Drawing.Size(81, 23);
            this.CipherButton.TabIndex = 3;
            this.CipherButton.Text = "Szyfruj";
            this.CipherButton.UseVisualStyleBackColor = true;
            this.CipherButton.Click += new System.EventHandler(this.CipherButton_Click);
            // 
            // CipherKeyTextBox
            // 
            this.CipherKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CipherKeyTextBox.Location = new System.Drawing.Point(94, 175);
            this.CipherKeyTextBox.Name = "CipherKeyTextBox";
            this.CipherKeyTextBox.Size = new System.Drawing.Size(230, 20);
            this.CipherKeyTextBox.TabIndex = 2;
            this.CipherKeyTextBox.TextChanged += new System.EventHandler(this.CipherKeyTextBox_TextChanged);
            // 
            // RawInputTextBox
            // 
            this.RawInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RawInputTextBox.Location = new System.Drawing.Point(3, 16);
            this.RawInputTextBox.Name = "RawInputTextBox";
            this.RawInputTextBox.Size = new System.Drawing.Size(408, 151);
            this.RawInputTextBox.TabIndex = 0;
            this.RawInputTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tekst do zaszyfrowania:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CipheredOutputTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wynik:";
            // 
            // CipheredOutputTextBox
            // 
            this.CipheredOutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CipheredOutputTextBox.Location = new System.Drawing.Point(3, 16);
            this.CipheredOutputTextBox.Name = "CipheredOutputTextBox";
            this.CipheredOutputTextBox.ReadOnly = true;
            this.CipheredOutputTextBox.Size = new System.Drawing.Size(408, 175);
            this.CipheredOutputTextBox.TabIndex = 0;
            this.CipheredOutputTextBox.Text = "";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Controls.Add(this.tabPage3);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 24);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(434, 437);
            this.MainTabControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "Form1";
            this.Text = "Szyfrator 2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tekstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szyfrogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szyfrogramToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tekstToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DecipherButton;
        private System.Windows.Forms.TextBox DecipherKeyTextBox;
        private System.Windows.Forms.RichTextBox CipheredInputTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RawOutputTextBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CipherButton;
        private System.Windows.Forms.TextBox CipherKeyTextBox;
        private System.Windows.Forms.RichTextBox RawInputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox CipheredOutputTextBox;
        private System.Windows.Forms.TabControl MainTabControl;
    }
}

