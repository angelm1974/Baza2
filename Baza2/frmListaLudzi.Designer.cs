namespace Baza2
{
    partial class frmListaLudzi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaLudzi));
            this.czlowiekSetDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNowy = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czlowiekSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.czlowiekSetDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.czlowiekSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // czlowiekSetDataGridView
            // 
            this.czlowiekSetDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.czlowiekSetDataGridView.AutoGenerateColumns = false;
            this.czlowiekSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.czlowiekSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.czlowiekSetDataGridView.DataSource = this.czlowiekSetBindingSource;
            this.czlowiekSetDataGridView.Location = new System.Drawing.Point(12, 12);
            this.czlowiekSetDataGridView.Name = "czlowiekSetDataGridView";
            this.czlowiekSetDataGridView.Size = new System.Drawing.Size(529, 261);
            this.czlowiekSetDataGridView.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.btnZamknij);
            this.panel1.Controls.Add(this.btnUsun);
            this.panel1.Controls.Add(this.btnNowy);
            this.panel1.Controls.Add(this.btnEdytuj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 62);
            this.panel1.TabIndex = 12;
            // 
            // btnNowy
            // 
            this.btnNowy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNowy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNowy.ImageKey = "023-simulation.png";
            this.btnNowy.ImageList = this.imageList1;
            this.btnNowy.Location = new System.Drawing.Point(10, 21);
            this.btnNowy.Name = "btnNowy";
            this.btnNowy.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnNowy.Size = new System.Drawing.Size(81, 29);
            this.btnNowy.TabIndex = 1;
            this.btnNowy.Text = "&Nowy";
            this.btnNowy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNowy.UseVisualStyleBackColor = true;
            this.btnNowy.Click += new System.EventHandler(this.btnNowy_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdytuj.Image = ((System.Drawing.Image)(resources.GetObject("btnEdytuj.Image")));
            this.btnEdytuj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdytuj.Location = new System.Drawing.Point(97, 21);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnEdytuj.Size = new System.Drawing.Size(75, 29);
            this.btnEdytuj.TabIndex = 0;
            this.btnEdytuj.Text = "&Edytuj";
            this.btnEdytuj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdytuj.UseVisualStyleBackColor = true;
            // 
            // btnUsun
            // 
            this.btnUsun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUsun.Image = ((System.Drawing.Image)(resources.GetObject("btnUsun.Image")));
            this.btnUsun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsun.Location = new System.Drawing.Point(178, 21);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnUsun.Size = new System.Drawing.Size(75, 29);
            this.btnUsun.TabIndex = 2;
            this.btnUsun.Text = "&Usuń";
            this.btnUsun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsun.UseVisualStyleBackColor = true;
            // 
            // btnZamknij
            // 
            this.btnZamknij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZamknij.Image = ((System.Drawing.Image)(resources.GetObject("btnZamknij.Image")));
            this.btnZamknij.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZamknij.Location = new System.Drawing.Point(466, 21);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnZamknij.Size = new System.Drawing.Size(75, 29);
            this.btnZamknij.TabIndex = 3;
            this.btnZamknij.Text = "&Zamknij";
            this.btnZamknij.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZamknij.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "imie";
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "imie";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nazwisko";
            this.dataGridViewTextBoxColumn3.FillWeight = 150F;
            this.dataGridViewTextBoxColumn3.HeaderText = "nazwisko";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "wiek";
            this.dataGridViewTextBoxColumn4.FillWeight = 50F;
            this.dataGridViewTextBoxColumn4.HeaderText = "wiek";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // czlowiekSetBindingSource
            // 
            this.czlowiekSetBindingSource.DataSource = typeof(Baza2.czlowiekSet);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "001-algorithm.png");
            this.imageList1.Images.SetKeyName(1, "002-analysis.png");
            this.imageList1.Images.SetKeyName(2, "003-applications.png");
            this.imageList1.Images.SetKeyName(3, "004-authorize.png");
            this.imageList1.Images.SetKeyName(4, "005-binary-code.png");
            this.imageList1.Images.SetKeyName(5, "006-browser.png");
            this.imageList1.Images.SetKeyName(6, "007-code.png");
            this.imageList1.Images.SetKeyName(7, "008-cyberspace.png");
            this.imageList1.Images.SetKeyName(8, "009-bug.png");
            this.imageList1.Images.SetKeyName(9, "010-developer.png");
            this.imageList1.Images.SetKeyName(10, "011-code-1.png");
            this.imageList1.Images.SetKeyName(11, "012-error.png");
            this.imageList1.Images.SetKeyName(12, "013-hacker.png");
            this.imageList1.Images.SetKeyName(13, "014-hosting.png");
            this.imageList1.Images.SetKeyName(14, "015-code-2.png");
            this.imageList1.Images.SetKeyName(15, "016-machine.png");
            this.imageList1.Images.SetKeyName(16, "017-programmer.png");
            this.imageList1.Images.SetKeyName(17, "018-programming.png");
            this.imageList1.Images.SetKeyName(18, "019-responsive.png");
            this.imageList1.Images.SetKeyName(19, "020-script.png");
            this.imageList1.Images.SetKeyName(20, "021-search-engine.png");
            this.imageList1.Images.SetKeyName(21, "022-server.png");
            this.imageList1.Images.SetKeyName(22, "023-simulation.png");
            this.imageList1.Images.SetKeyName(23, "024-operating-system.png");
            this.imageList1.Images.SetKeyName(24, "025-software.png");
            this.imageList1.Images.SetKeyName(25, "026-structure.png");
            this.imageList1.Images.SetKeyName(26, "027-web-design.png");
            this.imageList1.Images.SetKeyName(27, "028-website.png");
            this.imageList1.Images.SetKeyName(28, "029-website-1.png");
            this.imageList1.Images.SetKeyName(29, "030-programming-1.png");
            // 
            // frmListaLudzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 352);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.czlowiekSetDataGridView);
            this.Name = "frmListaLudzi";
            this.Text = "Lista osób";
            ((System.ComponentModel.ISupportInitialize)(this.czlowiekSetDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.czlowiekSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource czlowiekSetBindingSource;
        private System.Windows.Forms.DataGridView czlowiekSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.ImageList imageList1;
    }
}