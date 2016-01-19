namespace A_minha_aplicacao
{
    partial class frmArvore
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
            this.nudFazArvore = new System.Windows.Forms.NumericUpDown();
            this.btnFazArvore = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblArvore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudFazArvore)).BeginInit();
            this.SuspendLayout();
            // 
            // nudFazArvore
            // 
            this.nudFazArvore.Location = new System.Drawing.Point(13, 26);
            this.nudFazArvore.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudFazArvore.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudFazArvore.Name = "nudFazArvore";
            this.nudFazArvore.Size = new System.Drawing.Size(68, 20);
            this.nudFazArvore.TabIndex = 0;
            this.nudFazArvore.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnFazArvore
            // 
            this.btnFazArvore.Location = new System.Drawing.Point(13, 53);
            this.btnFazArvore.Name = "btnFazArvore";
            this.btnFazArvore.Size = new System.Drawing.Size(68, 23);
            this.btnFazArvore.TabIndex = 1;
            this.btnFazArvore.Text = "Faz árvore";
            this.btnFazArvore.UseVisualStyleBackColor = true;
            this.btnFazArvore.Click += new System.EventHandler(this.btnFazArvore_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(13, 83);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(68, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblArvore
            // 
            this.lblArvore.AutoSize = true;
            this.lblArvore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArvore.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblArvore.Location = new System.Drawing.Point(189, 26);
            this.lblArvore.Name = "lblArvore";
            this.lblArvore.Size = new System.Drawing.Size(60, 24);
            this.lblArvore.TabIndex = 3;
            this.lblArvore.Text = "label1";
            this.lblArvore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmArvore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 190);
            this.Controls.Add(this.lblArvore);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFazArvore);
            this.Controls.Add(this.nudFazArvore);
            this.Name = "frmArvore";
            this.Text = "frmArvore";
            this.Load += new System.EventHandler(this.frmArvore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFazArvore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudFazArvore;
        private System.Windows.Forms.Button btnFazArvore;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblArvore;
    }
}