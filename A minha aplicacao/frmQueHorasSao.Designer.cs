namespace A_minha_aplicacao
{
    partial class frmQueHorasSao
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
            this.pbHora = new System.Windows.Forms.ProgressBar();
            this.pbMinuto = new System.Windows.Forms.ProgressBar();
            this.pbSegundo = new System.Windows.Forms.ProgressBar();
            this.timerSegundos = new System.Windows.Forms.Timer(this.components);
            this.timerMinutos = new System.Windows.Forms.Timer(this.components);
            this.timerHoras = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblMinuto = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.rbAutomatico = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblHoraCompleta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbHora
            // 
            this.pbHora.Location = new System.Drawing.Point(13, 36);
            this.pbHora.Maximum = 24;
            this.pbHora.Name = "pbHora";
            this.pbHora.Size = new System.Drawing.Size(314, 23);
            this.pbHora.Step = 1;
            this.pbHora.TabIndex = 0;
            // 
            // pbMinuto
            // 
            this.pbMinuto.Location = new System.Drawing.Point(13, 76);
            this.pbMinuto.Maximum = 60;
            this.pbMinuto.Name = "pbMinuto";
            this.pbMinuto.Size = new System.Drawing.Size(575, 23);
            this.pbMinuto.Step = 1;
            this.pbMinuto.TabIndex = 1;
            // 
            // pbSegundo
            // 
            this.pbSegundo.Location = new System.Drawing.Point(13, 116);
            this.pbSegundo.Maximum = 60;
            this.pbSegundo.Name = "pbSegundo";
            this.pbSegundo.Size = new System.Drawing.Size(575, 23);
            this.pbSegundo.Step = 1;
            this.pbSegundo.TabIndex = 2;
            // 
            // timerSegundos
            // 
            this.timerSegundos.Interval = 1000;
            this.timerSegundos.Tick += new System.EventHandler(this.timerSegundos_Tick);
            // 
            // timerMinutos
            // 
            this.timerMinutos.Interval = 1500;
            this.timerMinutos.Tick += new System.EventHandler(this.timerMinutos_Tick);
            // 
            // timerHoras
            // 
            this.timerHoras.Interval = 2000;
            this.timerHoras.Tick += new System.EventHandler(this.timerHoras_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(334, 45);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "horas";
            // 
            // lblMinuto
            // 
            this.lblMinuto.AutoSize = true;
            this.lblMinuto.Location = new System.Drawing.Point(595, 85);
            this.lblMinuto.Name = "lblMinuto";
            this.lblMinuto.Size = new System.Drawing.Size(43, 13);
            this.lblMinuto.TabIndex = 4;
            this.lblMinuto.Text = "minutos";
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Location = new System.Drawing.Point(595, 125);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(53, 13);
            this.lblSegundo.TabIndex = 5;
            this.lblSegundo.Text = "segundos";
            // 
            // rbAutomatico
            // 
            this.rbAutomatico.AutoSize = true;
            this.rbAutomatico.Location = new System.Drawing.Point(13, 190);
            this.rbAutomatico.Name = "rbAutomatico";
            this.rbAutomatico.Size = new System.Drawing.Size(78, 17);
            this.rbAutomatico.TabIndex = 6;
            this.rbAutomatico.TabStop = true;
            this.rbAutomatico.Text = "Automático";
            this.rbAutomatico.UseVisualStyleBackColor = true;
            this.rbAutomatico.CheckedChanged += new System.EventHandler(this.rbAutomatico_CheckedChanged);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(13, 214);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(60, 17);
            this.rbManual.TabIndex = 7;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(127, 210);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblHoraCompleta
            // 
            this.lblHoraCompleta.AutoSize = true;
            this.lblHoraCompleta.Location = new System.Drawing.Point(613, 9);
            this.lblHoraCompleta.Name = "lblHoraCompleta";
            this.lblHoraCompleta.Size = new System.Drawing.Size(35, 13);
            this.lblHoraCompleta.TabIndex = 9;
            this.lblHoraCompleta.Text = "label1";
            // 
            // frmQueHorasSao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 261);
            this.Controls.Add(this.lblHoraCompleta);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.rbManual);
            this.Controls.Add(this.rbAutomatico);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.lblMinuto);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.pbSegundo);
            this.Controls.Add(this.pbMinuto);
            this.Controls.Add(this.pbHora);
            this.Name = "frmQueHorasSao";
            this.Text = "frmQueHorasSao";
            this.Load += new System.EventHandler(this.frmQueHorasSao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbHora;
        private System.Windows.Forms.ProgressBar pbMinuto;
        private System.Windows.Forms.ProgressBar pbSegundo;
        private System.Windows.Forms.Timer timerSegundos;
        private System.Windows.Forms.Timer timerMinutos;
        private System.Windows.Forms.Timer timerHoras;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblMinuto;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.RadioButton rbAutomatico;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblHoraCompleta;
    }
}