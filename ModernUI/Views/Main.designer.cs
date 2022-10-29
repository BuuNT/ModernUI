namespace ModernUI.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.layout1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblCurrentChildForm = new System.Windows.Forms.Label();
            this.icnCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlHorizontalLine = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDashBoard = new FontAwesome.Sharp.IconButton();
            this.pteLogo = new System.Windows.Forms.PictureBox();
            this.layout1.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icnCurrentChildForm)).BeginInit();
            this.pnlDesktop.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pteLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // layout1
            // 
            this.layout1.ColumnCount = 1;
            this.layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout1.Controls.Add(this.pnlStatus, 0, 2);
            this.layout1.Controls.Add(this.pnlTitle, 0, 0);
            this.layout1.Controls.Add(this.pnlDesktop, 0, 1);
            this.layout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout1.Location = new System.Drawing.Point(0, 0);
            this.layout1.Margin = new System.Windows.Forms.Padding(0);
            this.layout1.Name = "layout1";
            this.layout1.RowCount = 3;
            this.layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.layout1.Size = new System.Drawing.Size(2016, 1402);
            this.layout1.TabIndex = 0;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatus.Location = new System.Drawing.Point(0, 1359);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(2016, 43);
            this.pnlStatus.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStatus.Location = new System.Drawing.Point(1846, 12);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(142, 30);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Version 1.0";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.pnlTitle.Controls.Add(this.lblCurrentChildForm);
            this.pnlTitle.Controls.Add(this.icnCurrentChildForm);
            this.pnlTitle.Controls.Add(this.btnMaximize);
            this.pnlTitle.Controls.Add(this.btnMinimize);
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(2016, 70);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // lblCurrentChildForm
            // 
            this.lblCurrentChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentChildForm.AutoSize = true;
            this.lblCurrentChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCurrentChildForm.Location = new System.Drawing.Point(376, 20);
            this.lblCurrentChildForm.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCurrentChildForm.Name = "lblCurrentChildForm";
            this.lblCurrentChildForm.Size = new System.Drawing.Size(204, 74);
            this.lblCurrentChildForm.TabIndex = 3;
            this.lblCurrentChildForm.Text = "Home";
            // 
            // icnCurrentChildForm
            // 
            this.icnCurrentChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.icnCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.icnCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.icnCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icnCurrentChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.icnCurrentChildForm.IconSize = 62;
            this.icnCurrentChildForm.Location = new System.Drawing.Point(300, 9);
            this.icnCurrentChildForm.Margin = new System.Windows.Forms.Padding(6);
            this.icnCurrentChildForm.Name = "icnCurrentChildForm";
            this.icnCurrentChildForm.Size = new System.Drawing.Size(64, 62);
            this.icnCurrentChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icnCurrentChildForm.TabIndex = 4;
            this.icnCurrentChildForm.TabStop = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::ModernUI.Properties.Resources.white_maximize_32;
            this.btnMaximize.Location = new System.Drawing.Point(1884, 12);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(6);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(48, 47);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::ModernUI.Properties.Resources.white_minimize_32;
            this.btnMinimize.Location = new System.Drawing.Point(1824, 12);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(48, 47);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::ModernUI.Properties.Resources.white_exit_32;
            this.btnExit.Location = new System.Drawing.Point(1944, 12);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 47);
            this.btnExit.TabIndex = 0;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.pnlDesktop.Controls.Add(this.pnlHorizontalLine);
            this.pnlDesktop.Controls.Add(this.pnlMenu);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 70);
            this.pnlDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(2016, 1289);
            this.pnlDesktop.TabIndex = 0;
            // 
            // pnlHorizontalLine
            // 
            this.pnlHorizontalLine.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlHorizontalLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHorizontalLine.Location = new System.Drawing.Point(300, 0);
            this.pnlHorizontalLine.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHorizontalLine.Name = "pnlHorizontalLine";
            this.pnlHorizontalLine.Size = new System.Drawing.Size(1716, 10);
            this.pnlHorizontalLine.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(0)))), ((int)(((byte)(65)))));
            this.pnlMenu.Controls.Add(this.btnDashBoard);
            this.pnlMenu.Controls.Add(this.pteLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(6);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(300, 1289);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashBoard.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnDashBoard.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDashBoard.IconSize = 32;
            this.btnDashBoard.Location = new System.Drawing.Point(0, 246);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(6);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Padding = new System.Windows.Forms.Padding(20, 0, 40, 0);
            this.btnDashBoard.Rotation = 0D;
            this.btnDashBoard.Size = new System.Drawing.Size(300, 77);
            this.btnDashBoard.TabIndex = 1;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // pteLogo
            // 
            this.pteLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pteLogo.Image = global::ModernUI.Properties.Resources.blackcat_128;
            this.pteLogo.Location = new System.Drawing.Point(0, 0);
            this.pteLogo.Margin = new System.Windows.Forms.Padding(6);
            this.pteLogo.Name = "pteLogo";
            this.pteLogo.Size = new System.Drawing.Size(300, 246);
            this.pteLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pteLogo.TabIndex = 0;
            this.pteLogo.TabStop = false;
            this.pteLogo.Click += new System.EventHandler(this.pteLogo_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2016, 1402);
            this.Controls.Add(this.layout1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.Text = "Main";
            this.layout1.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icnCurrentChildForm)).EndInit();
            this.pnlDesktop.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pteLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout1;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnDashBoard;
        private System.Windows.Forms.PictureBox pteLogo;
        private System.Windows.Forms.Panel pnlHorizontalLine;
        private System.Windows.Forms.Label lblCurrentChildForm;
        private FontAwesome.Sharp.IconPictureBox icnCurrentChildForm;
    }
}

