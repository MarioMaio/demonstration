namespace A_minha_aplicacao
{
    partial class frmQuantoTempoPassou
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
            this.mocInicial = new System.Windows.Forms.MonthCalendar();
            this.mocFinal = new System.Windows.Forms.MonthCalendar();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblMeses = new System.Windows.Forms.Label();
            this.lblAnos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mocInicial
            // 
            this.mocInicial.Location = new System.Drawing.Point(13, 13);
            this.mocInicial.Name = "mocInicial";
            this.mocInicial.TabIndex = 0;
            this.mocInicial.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mocInicial_DateChanged);
            // 
            // mocFinal
            // 
            this.mocFinal.Location = new System.Drawing.Point(253, 13);
            this.mocFinal.Name = "mocFinal";
            this.mocFinal.TabIndex = 1;
            this.mocFinal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mocFinal_DateChanged);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(493, 13);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(28, 13);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "Dias";
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(492, 35);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(38, 13);
            this.lblMeses.TabIndex = 3;
            this.lblMeses.Text = "Meses";
            // 
            // lblAnos
            // 
            this.lblAnos.AutoSize = true;
            this.lblAnos.Location = new System.Drawing.Point(492, 58);
            this.lblAnos.Name = "lblAnos";
            this.lblAnos.Size = new System.Drawing.Size(31, 13);
            this.lblAnos.TabIndex = 4;
            this.lblAnos.Text = "Anos";
            // 
            // frmQuantoTempoPassou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 261);
            this.Controls.Add(this.lblAnos);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.mocFinal);
            this.Controls.Add(this.mocInicial);
            this.Name = "frmQuantoTempoPassou";
            this.Text = "frmQuantoTempoPassou";
            this.Load += new System.EventHandler(this.frmQuantoTempoPassou_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mocInicial;
        private System.Windows.Forms.MonthCalendar mocFinal;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.Label lblAnos;
    }
}