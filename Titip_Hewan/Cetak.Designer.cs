namespace Titip_Hewan
{
    partial class Cetak
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
            this.rtbPrint = new System.Windows.Forms.RichTextBox();
            this.btnCetak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbPrint
            // 
            this.rtbPrint.Location = new System.Drawing.Point(12, 12);
            this.rtbPrint.Name = "rtbPrint";
            this.rtbPrint.ReadOnly = true;
            this.rtbPrint.Size = new System.Drawing.Size(275, 300);
            this.rtbPrint.TabIndex = 0;
            this.rtbPrint.Text = "";
            // 
            // btnCetak
            // 
            this.btnCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.Location = new System.Drawing.Point(12, 318);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(274, 30);
            this.btnCetak.TabIndex = 1;
            this.btnCetak.Text = "Cetak!";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // Cetak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 359);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.rtbPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Cetak";
            this.Text = "Cetak Struk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPrint;
        private System.Windows.Forms.Button btnCetak;
    }
}