namespace WindowsFormsApplication1
{
    partial class ColossusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColossusForm));
            this.label_colossus = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.select_colossus = new System.Windows.Forms.RadioButton();
            this.search_label = new System.Windows.Forms.Label();
            this.select_animation = new System.Windows.Forms.RadioButton();
            this.viewout = new System.Windows.Forms.PictureBox();
            this.viewin = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.viewout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_colossus
            // 
            this.label_colossus.AutoSize = true;
            this.label_colossus.BackColor = System.Drawing.Color.Transparent;
            this.label_colossus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_colossus.Location = new System.Drawing.Point(24, 78);
            this.label_colossus.Name = "label_colossus";
            this.label_colossus.Size = new System.Drawing.Size(110, 22);
            this.label_colossus.TabIndex = 13;
            this.label_colossus.Text = "COLOSSUS";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "minotaur_A.nmo",
            "boss_A.nmo",
            "knight_A.nmo",
            "kirin_A.nmo",
            "bird_A.nmo",
            "minotaur_B.nmo",
            "minotaur_B_hige.nmo",
            "eel_B.nmo",
            "kame_A.nmo",
            "yamori_B.nmo",
            "narga_A.nmo",
            "narga_A_head.nmo",
            "leo_A.nmo",
            "poseidon_A.nmo",
            "snake_C.nmo",
            "cerberus_A.nmo",
            "minotaur_C.nmo",
            "buddha_A.nmo"});
            this.listBox1.Location = new System.Drawing.Point(16, 103);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 147);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(380, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "ANIMATION";
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox2.Enabled = false;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Choose a Colossus"});
            this.listBox2.Location = new System.Drawing.Point(269, 103);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox2.Size = new System.Drawing.Size(219, 147);
            this.listBox2.TabIndex = 19;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox2.Enter += new System.EventHandler(this.listBox2_Enter);
            this.listBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDown_1);
            // 
            // select_colossus
            // 
            this.select_colossus.Appearance = System.Windows.Forms.Appearance.Button;
            this.select_colossus.AutoSize = true;
            this.select_colossus.BackColor = System.Drawing.SystemColors.Control;
            this.select_colossus.Checked = true;
            this.select_colossus.Location = new System.Drawing.Point(193, 55);
            this.select_colossus.Name = "select_colossus";
            this.select_colossus.Size = new System.Drawing.Size(59, 23);
            this.select_colossus.TabIndex = 38;
            this.select_colossus.TabStop = true;
            this.select_colossus.Text = "Colossus";
            this.select_colossus.UseVisualStyleBackColor = false;
            this.select_colossus.CheckedChanged += new System.EventHandler(this.select_colossus_CheckedChanged);
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Location = new System.Drawing.Point(190, 13);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(56, 13);
            this.search_label.TabIndex = 37;
            this.search_label.Text = "Search for";
            // 
            // select_animation
            // 
            this.select_animation.Appearance = System.Windows.Forms.Appearance.Button;
            this.select_animation.AutoSize = true;
            this.select_animation.BackColor = System.Drawing.SystemColors.Control;
            this.select_animation.Location = new System.Drawing.Point(269, 55);
            this.select_animation.Name = "select_animation";
            this.select_animation.Size = new System.Drawing.Size(63, 23);
            this.select_animation.TabIndex = 39;
            this.select_animation.Text = "Animation";
            this.select_animation.UseVisualStyleBackColor = false;
            this.select_animation.CheckedChanged += new System.EventHandler(this.select_animation_CheckedChanged);
            // 
            // viewout
            // 
            this.viewout.BackColor = System.Drawing.Color.Transparent;
            this.viewout.Image = ((System.Drawing.Image)(resources.GetObject("viewout.Image")));
            this.viewout.Location = new System.Drawing.Point(358, 29);
            this.viewout.Name = "viewout";
            this.viewout.Size = new System.Drawing.Size(139, 28);
            this.viewout.TabIndex = 16;
            this.viewout.TabStop = false;
            this.viewout.Visible = false;
            this.viewout.Click += new System.EventHandler(this.viewout_Click);
            this.viewout.MouseLeave += new System.EventHandler(this.viewout_MouseLeave);
            // 
            // viewin
            // 
            this.viewin.BackColor = System.Drawing.Color.Transparent;
            this.viewin.Image = ((System.Drawing.Image)(resources.GetObject("viewin.Image")));
            this.viewin.Location = new System.Drawing.Point(358, 29);
            this.viewin.Name = "viewin";
            this.viewin.Size = new System.Drawing.Size(139, 28);
            this.viewin.TabIndex = 15;
            this.viewin.TabStop = false;
            this.viewin.MouseEnter += new System.EventHandler(this.viewin_MouseEnter);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(181, 71);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.resource2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 262);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(193, 29);
            this.comboBox1.MaxLength = 40;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.copyToolStripMenuItem.Text = "Copy to Clipboard";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip2.Size = new System.Drawing.Size(172, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem1.Text = "Copy to Clipboard";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ColossusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 262);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.select_animation);
            this.Controls.Add(this.viewout);
            this.Controls.Add(this.viewin);
            this.Controls.Add(this.select_colossus);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label_colossus);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ColossusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colossus Viewer";
            this.Load += new System.EventHandler(this.ColossusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_colossus;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox viewin;
        private System.Windows.Forms.PictureBox viewout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RadioButton select_colossus;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.RadioButton select_animation;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}