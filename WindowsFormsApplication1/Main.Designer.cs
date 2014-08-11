namespace WindowsFormsApplication1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.sotc_path = new System.Windows.Forms.ComboBox();
            this.path_state = new System.Windows.Forms.Label();
            this.nomad_link = new System.Windows.Forms.LinkLabel();
            this.open_obj = new System.Windows.Forms.Button();
            this.creditsout = new System.Windows.Forms.PictureBox();
            this.miscout = new System.Windows.Forms.PictureBox();
            this.wanderout = new System.Windows.Forms.PictureBox();
            this.colossusout = new System.Windows.Forms.PictureBox();
            this.creditsin = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.miscin = new System.Windows.Forms.PictureBox();
            this.wanderin = new System.Windows.Forms.PictureBox();
            this.colossusin = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_disc_type = new System.Windows.Forms.Label();
            this.fyle_system_group = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.creditsout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miscout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wanderout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colossusout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditsin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miscin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wanderin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colossusin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.fyle_system_group.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select NICO.DAT path";
            // 
            // sotc_path
            // 
            this.sotc_path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sotc_path.FormattingEnabled = true;
            this.sotc_path.Items.AddRange(new object[] {
            "Browse"});
            this.sotc_path.Location = new System.Drawing.Point(358, 23);
            this.sotc_path.Name = "sotc_path";
            this.sotc_path.Size = new System.Drawing.Size(140, 21);
            this.sotc_path.TabIndex = 12;
            this.sotc_path.SelectedIndexChanged += new System.EventHandler(this.sotc_SelectedIndexChanged);
            // 
            // path_state
            // 
            this.path_state.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.path_state.AutoSize = true;
            this.path_state.BackColor = System.Drawing.SystemColors.Control;
            this.path_state.ForeColor = System.Drawing.Color.DarkRed;
            this.path_state.Location = new System.Drawing.Point(425, 47);
            this.path_state.Name = "path_state";
            this.path_state.Size = new System.Drawing.Size(73, 13);
            this.path_state.TabIndex = 13;
            this.path_state.Text = "CHANGING...";
            this.path_state.Visible = false;
            // 
            // nomad_link
            // 
            this.nomad_link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nomad_link.AutoSize = true;
            this.nomad_link.BackColor = System.Drawing.Color.Transparent;
            this.nomad_link.Location = new System.Drawing.Point(6, 12);
            this.nomad_link.Name = "nomad_link";
            this.nomad_link.Size = new System.Drawing.Size(72, 13);
            this.nomad_link.TabIndex = 14;
            this.nomad_link.TabStop = true;
            this.nomad_link.Text = "Nomad\'s Blog";
            this.nomad_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nomad_link_LinkClicked);
            // 
            // open_obj
            // 
            this.open_obj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.open_obj.Location = new System.Drawing.Point(372, 230);
            this.open_obj.Name = "open_obj";
            this.open_obj.Size = new System.Drawing.Size(126, 23);
            this.open_obj.TabIndex = 15;
            this.open_obj.Text = "View exported 3D file";
            this.open_obj.UseVisualStyleBackColor = true;
            this.open_obj.Click += new System.EventHandler(this.button1_Click);
            // 
            // creditsout
            // 
            this.creditsout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.creditsout.Image = ((System.Drawing.Image)(resources.GetObject("creditsout.Image")));
            this.creditsout.Location = new System.Drawing.Point(33, 189);
            this.creditsout.Name = "creditsout";
            this.creditsout.Size = new System.Drawing.Size(140, 29);
            this.creditsout.TabIndex = 10;
            this.creditsout.TabStop = false;
            this.creditsout.Visible = false;
            this.creditsout.Click += new System.EventHandler(this.creditsout_Click);
            this.creditsout.MouseLeave += new System.EventHandler(this.creditsout_MouseLeave);
            // 
            // miscout
            // 
            this.miscout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.miscout.Image = ((System.Drawing.Image)(resources.GetObject("miscout.Image")));
            this.miscout.Location = new System.Drawing.Point(33, 120);
            this.miscout.Name = "miscout";
            this.miscout.Size = new System.Drawing.Size(140, 29);
            this.miscout.TabIndex = 9;
            this.miscout.TabStop = false;
            this.miscout.Visible = false;
            this.miscout.Click += new System.EventHandler(this.miscout_Click);
            this.miscout.MouseLeave += new System.EventHandler(this.miscout_MouseLeave);
            // 
            // wanderout
            // 
            this.wanderout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wanderout.Image = ((System.Drawing.Image)(resources.GetObject("wanderout.Image")));
            this.wanderout.Location = new System.Drawing.Point(33, 155);
            this.wanderout.Name = "wanderout";
            this.wanderout.Size = new System.Drawing.Size(140, 28);
            this.wanderout.TabIndex = 8;
            this.wanderout.TabStop = false;
            this.wanderout.Visible = false;
            this.wanderout.Click += new System.EventHandler(this.wanderout_Click);
            this.wanderout.MouseLeave += new System.EventHandler(this.wanderout_MouseLeave);
            // 
            // colossusout
            // 
            this.colossusout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.colossusout.Image = ((System.Drawing.Image)(resources.GetObject("colossusout.Image")));
            this.colossusout.Location = new System.Drawing.Point(33, 86);
            this.colossusout.Name = "colossusout";
            this.colossusout.Size = new System.Drawing.Size(140, 28);
            this.colossusout.TabIndex = 7;
            this.colossusout.TabStop = false;
            this.colossusout.Visible = false;
            this.colossusout.Click += new System.EventHandler(this.colossusout_Click);
            this.colossusout.MouseLeave += new System.EventHandler(this.colossusout_MouseLeave);
            // 
            // creditsin
            // 
            this.creditsin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.creditsin.Image = ((System.Drawing.Image)(resources.GetObject("creditsin.Image")));
            this.creditsin.Location = new System.Drawing.Point(33, 189);
            this.creditsin.Name = "creditsin";
            this.creditsin.Size = new System.Drawing.Size(140, 29);
            this.creditsin.TabIndex = 6;
            this.creditsin.TabStop = false;
            this.creditsin.MouseEnter += new System.EventHandler(this.creditsin_MouseEnter);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(181, 71);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // miscin
            // 
            this.miscin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.miscin.Image = ((System.Drawing.Image)(resources.GetObject("miscin.Image")));
            this.miscin.Location = new System.Drawing.Point(33, 120);
            this.miscin.Name = "miscin";
            this.miscin.Size = new System.Drawing.Size(140, 29);
            this.miscin.TabIndex = 4;
            this.miscin.TabStop = false;
            this.miscin.MouseEnter += new System.EventHandler(this.miscin_MouseEnter);
            // 
            // wanderin
            // 
            this.wanderin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wanderin.Image = ((System.Drawing.Image)(resources.GetObject("wanderin.Image")));
            this.wanderin.Location = new System.Drawing.Point(33, 155);
            this.wanderin.Name = "wanderin";
            this.wanderin.Size = new System.Drawing.Size(140, 28);
            this.wanderin.TabIndex = 3;
            this.wanderin.TabStop = false;
            this.wanderin.MouseEnter += new System.EventHandler(this.wanderin_MouseEnter);
            // 
            // colossusin
            // 
            this.colossusin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.colossusin.Image = ((System.Drawing.Image)(resources.GetObject("colossusin.Image")));
            this.colossusin.Location = new System.Drawing.Point(33, 86);
            this.colossusin.Name = "colossusin";
            this.colossusin.Size = new System.Drawing.Size(140, 28);
            this.colossusin.TabIndex = 2;
            this.colossusin.TabStop = false;
            this.colossusin.MouseEnter += new System.EventHandler(this.colossusin_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.resource2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_disc_type
            // 
            this.label_disc_type.AutoSize = true;
            this.label_disc_type.BackColor = System.Drawing.Color.Transparent;
            this.label_disc_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_disc_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_disc_type.Location = new System.Drawing.Point(10, 16);
            this.label_disc_type.Name = "label_disc_type";
            this.label_disc_type.Size = new System.Drawing.Size(117, 20);
            this.label_disc_type.TabIndex = 16;
            this.label_disc_type.Text = "No data loaded";
            // 
            // fyle_system_group
            // 
            this.fyle_system_group.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fyle_system_group.AutoSize = true;
            this.fyle_system_group.Controls.Add(this.label_disc_type);
            this.fyle_system_group.Location = new System.Drawing.Point(210, 0);
            this.fyle_system_group.Name = "fyle_system_group";
            this.fyle_system_group.Size = new System.Drawing.Size(133, 52);
            this.fyle_system_group.TabIndex = 17;
            this.fyle_system_group.TabStop = false;
            this.fyle_system_group.Text = "Game version";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(372, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Game version info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(79, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Black Bird Blog(PT)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(179, 12);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(111, 13);
            this.linkLabel2.TabIndex = 20;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "WWWArea\'s Channel";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.nomad_link);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(0, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 35);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team links";
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "Windows Metro (White).vssf");
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(510, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fyle_system_group);
            this.Controls.Add(this.open_obj);
            this.Controls.Add(this.path_state);
            this.Controls.Add(this.sotc_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.creditsout);
            this.Controls.Add(this.miscout);
            this.Controls.Add(this.wanderout);
            this.Controls.Add(this.colossusout);
            this.Controls.Add(this.creditsin);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.miscin);
            this.Controls.Add(this.wanderin);
            this.Controls.Add(this.colossusin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SotC Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.creditsout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miscout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wanderout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colossusout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditsin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miscin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wanderin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colossusin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.fyle_system_group.ResumeLayout(false);
            this.fyle_system_group.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox colossusin;
        private System.Windows.Forms.PictureBox wanderin;
        private System.Windows.Forms.PictureBox miscin;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox creditsin;
        private System.Windows.Forms.PictureBox creditsout;
        private System.Windows.Forms.PictureBox miscout;
        private System.Windows.Forms.PictureBox wanderout;
        private System.Windows.Forms.PictureBox colossusout;
        private System.Windows.Forms.LinkLabel nomad_link;
        private System.Windows.Forms.Button open_obj;
        private System.Windows.Forms.GroupBox fyle_system_group;
        private System.Windows.Forms.Label label_disc_type;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox sotc_path;
        protected System.Windows.Forms.Label path_state;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
    }
}

