
namespace Duit_Tracker
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
            this.lblKasMasuk = new System.Windows.Forms.Label();
            this.lblKasKeluar = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNilaiSaldo = new System.Windows.Forms.Label();
            this.lblNilaiKasKeluar = new System.Windows.Forms.Label();
            this.lblNilaiKasMasuk = new System.Windows.Forms.Label();
            this.dgvSejarahTransaksi = new System.Windows.Forms.DataGridView();
            this.lblSejarahTransaksi = new System.Windows.Forms.Label();
            this.btnTransaksiBaru = new Duit_Tracker.RoundButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSejarahTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKasMasuk
            // 
            this.lblKasMasuk.AutoSize = true;
            this.lblKasMasuk.Location = new System.Drawing.Point(11, 11);
            this.lblKasMasuk.Name = "lblKasMasuk";
            this.lblKasMasuk.Size = new System.Drawing.Size(60, 13);
            this.lblKasMasuk.TabIndex = 0;
            this.lblKasMasuk.Text = "Kas Masuk\r\n";
            // 
            // lblKasKeluar
            // 
            this.lblKasKeluar.AutoSize = true;
            this.lblKasKeluar.Location = new System.Drawing.Point(11, 33);
            this.lblKasKeluar.Name = "lblKasKeluar";
            this.lblKasKeluar.Size = new System.Drawing.Size(58, 13);
            this.lblKasKeluar.TabIndex = 1;
            this.lblKasKeluar.Text = "Kas Keluar";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(11, 55);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(39, 13);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblNilaiSaldo);
            this.panel1.Controls.Add(this.lblNilaiKasKeluar);
            this.panel1.Controls.Add(this.lblNilaiKasMasuk);
            this.panel1.Controls.Add(this.lblSaldo);
            this.panel1.Controls.Add(this.lblKasKeluar);
            this.panel1.Controls.Add(this.lblKasMasuk);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 80);
            this.panel1.TabIndex = 3;
            // 
            // lblNilaiSaldo
            // 
            this.lblNilaiSaldo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNilaiSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNilaiSaldo.Location = new System.Drawing.Point(257, 55);
            this.lblNilaiSaldo.Name = "lblNilaiSaldo";
            this.lblNilaiSaldo.Size = new System.Drawing.Size(60, 13);
            this.lblNilaiSaldo.TabIndex = 5;
            this.lblNilaiSaldo.Text = "0";
            this.lblNilaiSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNilaiKasKeluar
            // 
            this.lblNilaiKasKeluar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNilaiKasKeluar.Location = new System.Drawing.Point(257, 33);
            this.lblNilaiKasKeluar.Name = "lblNilaiKasKeluar";
            this.lblNilaiKasKeluar.Size = new System.Drawing.Size(60, 13);
            this.lblNilaiKasKeluar.TabIndex = 4;
            this.lblNilaiKasKeluar.Text = "0";
            this.lblNilaiKasKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNilaiKasMasuk
            // 
            this.lblNilaiKasMasuk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNilaiKasMasuk.Location = new System.Drawing.Point(257, 11);
            this.lblNilaiKasMasuk.Name = "lblNilaiKasMasuk";
            this.lblNilaiKasMasuk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNilaiKasMasuk.Size = new System.Drawing.Size(60, 13);
            this.lblNilaiKasMasuk.TabIndex = 3;
            this.lblNilaiKasMasuk.Text = "0";
            this.lblNilaiKasMasuk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvSejarahTransaksi
            // 
            this.dgvSejarahTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSejarahTransaksi.Location = new System.Drawing.Point(12, 139);
            this.dgvSejarahTransaksi.Name = "dgvSejarahTransaksi";
            this.dgvSejarahTransaksi.Size = new System.Drawing.Size(331, 188);
            this.dgvSejarahTransaksi.TabIndex = 6;
            // 
            // lblSejarahTransaksi
            // 
            this.lblSejarahTransaksi.AutoSize = true;
            this.lblSejarahTransaksi.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSejarahTransaksi.Location = new System.Drawing.Point(98, 117);
            this.lblSejarahTransaksi.Name = "lblSejarahTransaksi";
            this.lblSejarahTransaksi.Size = new System.Drawing.Size(156, 19);
            this.lblSejarahTransaksi.TabIndex = 7;
            this.lblSejarahTransaksi.Text = "Sejarah Transaksi";
            // 
            // btnTransaksiBaru
            // 
            this.btnTransaksiBaru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTransaksiBaru.Image = ((System.Drawing.Image)(resources.GetObject("btnTransaksiBaru.Image")));
            this.btnTransaksiBaru.Location = new System.Drawing.Point(147, 343);
            this.btnTransaksiBaru.Name = "btnTransaksiBaru";
            this.btnTransaksiBaru.Size = new System.Drawing.Size(61, 61);
            this.btnTransaksiBaru.TabIndex = 5;
            this.btnTransaksiBaru.UseVisualStyleBackColor = false;
            this.btnTransaksiBaru.Click += new System.EventHandler(this.btnTransaksiBaru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(355, 416);
            this.Controls.Add(this.lblSejarahTransaksi);
            this.Controls.Add(this.dgvSejarahTransaksi);
            this.Controls.Add(this.btnTransaksiBaru);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duit Tracker";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSejarahTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKasMasuk;
        private System.Windows.Forms.Label lblKasKeluar;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNilaiSaldo;
        private System.Windows.Forms.Label lblNilaiKasKeluar;
        private System.Windows.Forms.Label lblNilaiKasMasuk;
        private RoundButton btnTransaksiBaru;
        private System.Windows.Forms.DataGridView dgvSejarahTransaksi;
        private System.Windows.Forms.Label lblSejarahTransaksi;
    }
}

