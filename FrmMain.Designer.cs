namespace LapKisIsk10COP2000
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvOsszesito = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFenymasolasraOsszesen = new System.Windows.Forms.TextBox();
            this.cbDiakok = new System.Windows.Forms.ComboBox();
            this.rtbDiakTranzakcioi = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.újTételToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.számlaKimutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsszesito)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOsszesito
            // 
            this.dgvOsszesito.AllowUserToAddRows = false;
            this.dgvOsszesito.AllowUserToDeleteRows = false;
            this.dgvOsszesito.AllowUserToResizeColumns = false;
            this.dgvOsszesito.AllowUserToResizeRows = false;
            this.dgvOsszesito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOsszesito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsszesito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvOsszesito.Location = new System.Drawing.Point(12, 12);
            this.dgvOsszesito.Name = "dgvOsszesito";
            this.dgvOsszesito.RowHeadersVisible = false;
            this.dgvOsszesito.RowTemplate.Height = 25;
            this.dgvOsszesito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOsszesito.Size = new System.Drawing.Size(240, 403);
            this.dgvOsszesito.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NÉV";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Befizetés";
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "fénymásolásra:";
            // 
            // tbFenymasolasraOsszesen
            // 
            this.tbFenymasolasraOsszesen.Location = new System.Drawing.Point(418, 19);
            this.tbFenymasolasraOsszesen.Name = "tbFenymasolasraOsszesen";
            this.tbFenymasolasraOsszesen.Size = new System.Drawing.Size(144, 29);
            this.tbFenymasolasraOsszesen.TabIndex = 2;
            // 
            // cbDiakok
            // 
            this.cbDiakok.FormattingEnabled = true;
            this.cbDiakok.Location = new System.Drawing.Point(298, 73);
            this.cbDiakok.Name = "cbDiakok";
            this.cbDiakok.Size = new System.Drawing.Size(264, 29);
            this.cbDiakok.TabIndex = 3;
            this.cbDiakok.SelectedIndexChanged += new System.EventHandler(this.cbDiakok_SelectedIndexChanged);
            // 
            // rtbDiakTranzakcioi
            // 
            this.rtbDiakTranzakcioi.Location = new System.Drawing.Point(298, 121);
            this.rtbDiakTranzakcioi.Name = "rtbDiakTranzakcioi";
            this.rtbDiakTranzakcioi.Size = new System.Drawing.Size(264, 294);
            this.rtbDiakTranzakcioi.TabIndex = 4;
            this.rtbDiakTranzakcioi.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újTételToolStripMenuItem,
            this.számlaKimutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(613, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 427);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // újTételToolStripMenuItem
            // 
            this.újTételToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.újTételToolStripMenuItem.Name = "újTételToolStripMenuItem";
            this.újTételToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.újTételToolStripMenuItem.Size = new System.Drawing.Size(113, 75);
            this.újTételToolStripMenuItem.Text = "új tétel";
            this.újTételToolStripMenuItem.Click += new System.EventHandler(this.újTételToolStripMenuItem_Click);
            // 
            // számlaKimutToolStripMenuItem
            // 
            this.számlaKimutToolStripMenuItem.Name = "számlaKimutToolStripMenuItem";
            this.számlaKimutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.számlaKimutToolStripMenuItem.Size = new System.Drawing.Size(113, 69);
            this.számlaKimutToolStripMenuItem.Text = "számla kimut.";
            this.számlaKimutToolStripMenuItem.Click += new System.EventHandler(this.számlaKimutToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 427);
            this.Controls.Add(this.rtbDiakTranzakcioi);
            this.Controls.Add(this.cbDiakok);
            this.Controls.Add(this.tbFenymasolasraOsszesen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOsszesito);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Osztálypénztár összesítő";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsszesito)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvOsszesito;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label1;
        private TextBox tbFenymasolasraOsszesen;
        private ComboBox cbDiakok;
        private RichTextBox rtbDiakTranzakcioi;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem újTételToolStripMenuItem;
        private ToolStripMenuItem számlaKimutToolStripMenuItem;
    }
}