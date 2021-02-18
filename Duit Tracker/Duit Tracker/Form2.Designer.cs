
namespace Duit_Tracker
{
    partial class Form2
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
            this.btnPendapatan = new System.Windows.Forms.Button();
            this.btnPengeluaran = new System.Windows.Forms.Button();
            this.lblTipe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPendapatan
            // 
            this.btnPendapatan.Location = new System.Drawing.Point(28, 44);
            this.btnPendapatan.Name = "btnPendapatan";
            this.btnPendapatan.Size = new System.Drawing.Size(95, 46);
            this.btnPendapatan.TabIndex = 0;
            this.btnPendapatan.Text = "Pendapatan";
            this.btnPendapatan.UseVisualStyleBackColor = true;
            this.btnPendapatan.Click += new System.EventHandler(this.btnPendapatan_Click);
            // 
            // btnPengeluaran
            // 
            this.btnPengeluaran.Location = new System.Drawing.Point(129, 44);
            this.btnPengeluaran.Name = "btnPengeluaran";
            this.btnPengeluaran.Size = new System.Drawing.Size(95, 46);
            this.btnPengeluaran.TabIndex = 1;
            this.btnPengeluaran.Text = "Pengeluaran";
            this.btnPengeluaran.UseVisualStyleBackColor = true;
            this.btnPengeluaran.Click += new System.EventHandler(this.btnPengeluaran_Click);
            // 
            // lblTipe
            // 
            this.lblTipe.AutoSize = true;
            this.lblTipe.Location = new System.Drawing.Point(100, 18);
            this.lblTipe.Name = "lblTipe";
            this.lblTipe.Size = new System.Drawing.Size(49, 13);
            this.lblTipe.TabIndex = 2;
            this.lblTipe.Text = "Pilih tipe:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 116);
            this.Controls.Add(this.lblTipe);
            this.Controls.Add(this.btnPengeluaran);
            this.Controls.Add(this.btnPendapatan);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duit Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPendapatan;
        private System.Windows.Forms.Button btnPengeluaran;
        private System.Windows.Forms.Label lblTipe;
    }
}