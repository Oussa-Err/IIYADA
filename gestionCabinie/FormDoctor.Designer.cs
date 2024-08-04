namespace gestionCabinie
{
    partial class FormDoctor
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.BtnConsultation = new FontAwesome.Sharp.IconButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerMédicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerConsultationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parcourirConsultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(132)))), ((int)(((byte)(116)))));
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Magic;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(86, 214);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(487, 59);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Parcourir Consultations";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(132)))), ((int)(((byte)(116)))));
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.M;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(86, 150);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(487, 57);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Gerer les Medicaments\r\n";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // BtnConsultation
            // 
            this.BtnConsultation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnConsultation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(132)))), ((int)(((byte)(116)))));
            this.BtnConsultation.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnConsultation.ForeColor = System.Drawing.Color.White;
            this.BtnConsultation.IconChar = FontAwesome.Sharp.IconChar.Wpforms;
            this.BtnConsultation.IconColor = System.Drawing.Color.White;
            this.BtnConsultation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConsultation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultation.Location = new System.Drawing.Point(86, 84);
            this.BtnConsultation.Name = "BtnConsultation";
            this.BtnConsultation.Size = new System.Drawing.Size(487, 60);
            this.BtnConsultation.TabIndex = 0;
            this.BtnConsultation.Text = "Gerer les consultations\r\n";
            this.BtnConsultation.UseVisualStyleBackColor = false;
            this.BtnConsultation.Click += new System.EventHandler(this.BtnConsultation_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // navigationToolStripMenuItem
            // 
            this.navigationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerMédicamentToolStripMenuItem,
            this.gérerConsultationToolStripMenuItem1,
            this.parcourirConsultationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            this.navigationToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.navigationToolStripMenuItem.Text = "&File";
            // 
            // gérerMédicamentToolStripMenuItem
            // 
            this.gérerMédicamentToolStripMenuItem.Name = "gérerMédicamentToolStripMenuItem";
            this.gérerMédicamentToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.gérerMédicamentToolStripMenuItem.Text = "Gérer &Médicament";
            // 
            // gérerConsultationToolStripMenuItem1
            // 
            this.gérerConsultationToolStripMenuItem1.Name = "gérerConsultationToolStripMenuItem1";
            this.gérerConsultationToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.gérerConsultationToolStripMenuItem1.Text = "Gérer &Consultation";
            this.gérerConsultationToolStripMenuItem1.Click += new System.EventHandler(this.gérerConsultationToolStripMenuItem1_Click);
            // 
            // parcourirConsultationToolStripMenuItem
            // 
            this.parcourirConsultationToolStripMenuItem.Name = "parcourirConsultationToolStripMenuItem";
            this.parcourirConsultationToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.parcourirConsultationToolStripMenuItem.Text = "Parcourir C&onsultation";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 376);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.BtnConsultation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(683, 376);
            this.Name = "FormDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Doctor Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDocotr_FormClosing);
            this.Load += new System.EventHandler(this.FormDoctor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private FontAwesome.Sharp.IconButton BtnConsultation;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerMédicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerConsultationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parcourirConsultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}