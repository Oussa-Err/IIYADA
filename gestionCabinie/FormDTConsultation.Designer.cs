namespace gestionCabinie
{
    partial class FormDTConsultation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.DTConsultation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerConsultationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerMédicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parcourirConsultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DTConsultation)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // DTConsultation
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DTConsultation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DTConsultation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTConsultation.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTConsultation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DTConsultation.ColumnHeadersHeight = 4;
            this.DTConsultation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTConsultation.DefaultCellStyle = dataGridViewCellStyle3;
            this.DTConsultation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DTConsultation.Location = new System.Drawing.Point(37, 56);
            this.DTConsultation.Margin = new System.Windows.Forms.Padding(4);
            this.DTConsultation.Name = "DTConsultation";
            this.DTConsultation.RowHeadersVisible = false;
            this.DTConsultation.RowHeadersWidth = 51;
            this.DTConsultation.Size = new System.Drawing.Size(1224, 714);
            this.DTConsultation.TabIndex = 0;
            this.DTConsultation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DTConsultation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DTConsultation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DTConsultation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DTConsultation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DTConsultation.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DTConsultation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DTConsultation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DTConsultation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DTConsultation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTConsultation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DTConsultation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DTConsultation.ThemeStyle.HeaderStyle.Height = 4;
            this.DTConsultation.ThemeStyle.ReadOnly = false;
            this.DTConsultation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DTConsultation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DTConsultation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTConsultation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DTConsultation.ThemeStyle.RowsStyle.Height = 22;
            this.DTConsultation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DTConsultation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1301, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // navigationToolStripMenuItem
            // 
            this.navigationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerConsultationToolStripMenuItem1,
            this.gérerMédicamentToolStripMenuItem,
            this.parcourirConsultationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            this.navigationToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.navigationToolStripMenuItem.Text = "&File";
            // 
            // gérerConsultationToolStripMenuItem1
            // 
            this.gérerConsultationToolStripMenuItem1.Name = "gérerConsultationToolStripMenuItem1";
            this.gérerConsultationToolStripMenuItem1.Size = new System.Drawing.Size(237, 26);
            this.gérerConsultationToolStripMenuItem1.Text = "Gérer &Consultation";
            this.gérerConsultationToolStripMenuItem1.Click += new System.EventHandler(this.gérerConsultationToolStripMenuItem1_Click_1);
            // 
            // gérerMédicamentToolStripMenuItem
            // 
            this.gérerMédicamentToolStripMenuItem.Name = "gérerMédicamentToolStripMenuItem";
            this.gérerMédicamentToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.gérerMédicamentToolStripMenuItem.Text = "Gérer &Médicament";
            this.gérerMédicamentToolStripMenuItem.Click += new System.EventHandler(this.gérerMédicamentToolStripMenuItem_Click);
            // 
            // parcourirConsultationToolStripMenuItem
            // 
            this.parcourirConsultationToolStripMenuItem.Name = "parcourirConsultationToolStripMenuItem";
            this.parcourirConsultationToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.parcourirConsultationToolStripMenuItem.Text = "Parcourir C&onsultation";
            this.parcourirConsultationToolStripMenuItem.Click += new System.EventHandler(this.parcourirConsultationToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormDTConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1301, 820);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DTConsultation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1301, 820);
            this.Name = "FormDTConsultation";
            this.ShowIcon = false;
            this.Text = "Doctor Consultation";
            this.Load += new System.EventHandler(this.FormDTConsultation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTConsultation)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DataGridView DTConsultation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerMédicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerConsultationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parcourirConsultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}