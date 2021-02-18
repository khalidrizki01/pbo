
namespace Duit_Tracker
{
    partial class TransaksiPendapatan
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
            this.lblNominal = new System.Windows.Forms.Label();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.txtNominal = new System.Windows.Forms.TextBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNominal
            // 
            this.lblNominal.AutoSize = true;
            this.lblNominal.Location = new System.Drawing.Point(23, 25);
            this.lblNominal.Name = "lblNominal";
            this.lblNominal.Size = new System.Drawing.Size(45, 13);
            this.lblNominal.TabIndex = 0;
            this.lblNominal.Text = "Nominal";
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Location = new System.Drawing.Point(23, 51);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(62, 13);
            this.lblKeterangan.TabIndex = 3;
            this.lblKeterangan.Text = "Keterangan";
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(23, 92);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(46, 13);
            this.lblTanggal.TabIndex = 4;
            this.lblTanggal.Text = "Tanggal";
            // 
            // txtNominal
            // 
            this.txtNominal.Location = new System.Drawing.Point(102, 22);
            this.txtNominal.Name = "txtNominal";
            this.txtNominal.Size = new System.Drawing.Size(156, 20);
            this.txtNominal.TabIndex = 5;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(102, 48);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(156, 37);
            this.txtKeterangan.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(102, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd-MM-yyyy";
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(102, 93);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(156, 20);
            this.dtpTanggal.TabIndex = 9;
            this.dtpTanggal.Value = new System.DateTime(2021, 4, 9, 14, 47, 44, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TransaksiPendapatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 180);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.txtNominal);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.lblKeterangan);
            this.Controls.Add(this.lblNominal);
            this.Name = "TransaksiPendapatan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi Pendapatan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNominal;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.TextBox txtNominal;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Button btnCancel;
    }
}