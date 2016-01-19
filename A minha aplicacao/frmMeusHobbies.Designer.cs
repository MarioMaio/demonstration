namespace A_minha_aplicacao
{
    partial class frmMeusHobbies
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
            this.chbPesca = new System.Windows.Forms.CheckBox();
            this.chbLeitura = new System.Windows.Forms.CheckBox();
            this.chbCinema = new System.Windows.Forms.CheckBox();
            this.chbTeatro = new System.Windows.Forms.CheckBox();
            this.chbCaminhadas = new System.Windows.Forms.CheckBox();
            this.chbBricolage = new System.Windows.Forms.CheckBox();
            this.chbTricot = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chbPesca
            // 
            this.chbPesca.AutoSize = true;
            this.chbPesca.Location = new System.Drawing.Point(96, 12);
            this.chbPesca.Name = "chbPesca";
            this.chbPesca.Size = new System.Drawing.Size(56, 17);
            this.chbPesca.TabIndex = 0;
            this.chbPesca.Text = "Pesca";
            this.chbPesca.UseVisualStyleBackColor = true;
            // 
            // chbLeitura
            // 
            this.chbLeitura.AutoSize = true;
            this.chbLeitura.Location = new System.Drawing.Point(96, 35);
            this.chbLeitura.Name = "chbLeitura";
            this.chbLeitura.Size = new System.Drawing.Size(58, 17);
            this.chbLeitura.TabIndex = 1;
            this.chbLeitura.Text = "Leitura";
            this.chbLeitura.UseVisualStyleBackColor = true;
            // 
            // chbCinema
            // 
            this.chbCinema.AutoSize = true;
            this.chbCinema.Location = new System.Drawing.Point(96, 58);
            this.chbCinema.Name = "chbCinema";
            this.chbCinema.Size = new System.Drawing.Size(61, 17);
            this.chbCinema.TabIndex = 2;
            this.chbCinema.Text = "Cinema";
            this.chbCinema.UseVisualStyleBackColor = true;
            // 
            // chbTeatro
            // 
            this.chbTeatro.AutoSize = true;
            this.chbTeatro.Location = new System.Drawing.Point(96, 81);
            this.chbTeatro.Name = "chbTeatro";
            this.chbTeatro.Size = new System.Drawing.Size(57, 17);
            this.chbTeatro.TabIndex = 3;
            this.chbTeatro.Text = "Teatro";
            this.chbTeatro.UseVisualStyleBackColor = true;
            // 
            // chbCaminhadas
            // 
            this.chbCaminhadas.AutoSize = true;
            this.chbCaminhadas.Location = new System.Drawing.Point(96, 104);
            this.chbCaminhadas.Name = "chbCaminhadas";
            this.chbCaminhadas.Size = new System.Drawing.Size(84, 17);
            this.chbCaminhadas.TabIndex = 4;
            this.chbCaminhadas.Text = "Caminhadas";
            this.chbCaminhadas.UseVisualStyleBackColor = true;
            // 
            // chbBricolage
            // 
            this.chbBricolage.AutoSize = true;
            this.chbBricolage.Location = new System.Drawing.Point(96, 127);
            this.chbBricolage.Name = "chbBricolage";
            this.chbBricolage.Size = new System.Drawing.Size(70, 17);
            this.chbBricolage.TabIndex = 5;
            this.chbBricolage.Text = "Bricolage";
            this.chbBricolage.UseVisualStyleBackColor = true;
            // 
            // chbTricot
            // 
            this.chbTricot.AutoSize = true;
            this.chbTricot.Location = new System.Drawing.Point(96, 150);
            this.chbTricot.Name = "chbTricot";
            this.chbTricot.Size = new System.Drawing.Size(53, 17);
            this.chbTricot.TabIndex = 6;
            this.chbTricot.Text = "Tricot";
            this.chbTricot.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(96, 188);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmMeusHobbies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chbTricot);
            this.Controls.Add(this.chbBricolage);
            this.Controls.Add(this.chbCaminhadas);
            this.Controls.Add(this.chbTeatro);
            this.Controls.Add(this.chbCinema);
            this.Controls.Add(this.chbLeitura);
            this.Controls.Add(this.chbPesca);
            this.Name = "frmMeusHobbies";
            this.Text = "frmMeusHobbies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbPesca;
        private System.Windows.Forms.CheckBox chbLeitura;
        private System.Windows.Forms.CheckBox chbCinema;
        private System.Windows.Forms.CheckBox chbTeatro;
        private System.Windows.Forms.CheckBox chbCaminhadas;
        private System.Windows.Forms.CheckBox chbBricolage;
        private System.Windows.Forms.CheckBox chbTricot;
        private System.Windows.Forms.Button btnOk;
    }
}