namespace SuporteChamados
{
    partial class frmAvaliacao
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
            this.cmbQualidade = new System.Windows.Forms.ComboBox();
            this.cmbTempodeEspera = new System.Windows.Forms.ComboBox();
            this.cmbTempoAtendimento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAvaliar = new System.Windows.Forms.Button();
            this.rbResolveu = new System.Windows.Forms.RadioButton();
            this.rbNaoResolveu = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cmbQualidade
            // 
            this.cmbQualidade.BackColor = System.Drawing.SystemColors.Window;
            this.cmbQualidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQualidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQualidade.FormattingEnabled = true;
            this.cmbQualidade.Items.AddRange(new object[] {
            "☆",
            "☆☆",
            "☆☆☆",
            "☆☆☆☆",
            "☆☆☆☆☆"});
            this.cmbQualidade.Location = new System.Drawing.Point(58, 166);
            this.cmbQualidade.Name = "cmbQualidade";
            this.cmbQualidade.Size = new System.Drawing.Size(157, 28);
            this.cmbQualidade.TabIndex = 0;
            // 
            // cmbTempodeEspera
            // 
            this.cmbTempodeEspera.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTempodeEspera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTempodeEspera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTempodeEspera.FormattingEnabled = true;
            this.cmbTempodeEspera.Items.AddRange(new object[] {
            "Rápido",
            "Moderado",
            "Demorado"});
            this.cmbTempodeEspera.Location = new System.Drawing.Point(58, 255);
            this.cmbTempodeEspera.Name = "cmbTempodeEspera";
            this.cmbTempodeEspera.Size = new System.Drawing.Size(157, 28);
            this.cmbTempodeEspera.TabIndex = 1;
            // 
            // cmbTempoAtendimento
            // 
            this.cmbTempoAtendimento.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTempoAtendimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTempoAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTempoAtendimento.FormattingEnabled = true;
            this.cmbTempoAtendimento.Items.AddRange(new object[] {
            "Rápido",
            "Moderado",
            "Demorado"});
            this.cmbTempoAtendimento.Location = new System.Drawing.Point(58, 344);
            this.cmbTempoAtendimento.Name = "cmbTempoAtendimento";
            this.cmbTempoAtendimento.Size = new System.Drawing.Size(157, 28);
            this.cmbTempoAtendimento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(53, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qualidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(53, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tempo de Espera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(53, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tempo do Atendimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(173, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(438, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Avalie o Seu Atendimento";
            // 
            // btnAvaliar
            // 
            this.btnAvaliar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAvaliar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAvaliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvaliar.Location = new System.Drawing.Point(643, 340);
            this.btnAvaliar.Name = "btnAvaliar";
            this.btnAvaliar.Size = new System.Drawing.Size(123, 32);
            this.btnAvaliar.TabIndex = 8;
            this.btnAvaliar.Text = "Avaliar";
            this.btnAvaliar.UseVisualStyleBackColor = true;
            this.btnAvaliar.Click += new System.EventHandler(this.btnAvaliar_Click);
            // 
            // rbResolveu
            // 
            this.rbResolveu.AutoSize = true;
            this.rbResolveu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbResolveu.Location = new System.Drawing.Point(472, 166);
            this.rbResolveu.Name = "rbResolveu";
            this.rbResolveu.Size = new System.Drawing.Size(208, 28);
            this.rbResolveu.TabIndex = 9;
            this.rbResolveu.TabStop = true;
            this.rbResolveu.Text = "Resolveu o problema";
            this.rbResolveu.UseVisualStyleBackColor = true;
            // 
            // rbNaoResolveu
            // 
            this.rbNaoResolveu.AutoSize = true;
            this.rbNaoResolveu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNaoResolveu.Location = new System.Drawing.Point(472, 226);
            this.rbNaoResolveu.Name = "rbNaoResolveu";
            this.rbNaoResolveu.Size = new System.Drawing.Size(241, 28);
            this.rbNaoResolveu.TabIndex = 10;
            this.rbNaoResolveu.TabStop = true;
            this.rbNaoResolveu.Text = "Não resolveu o problema";
            this.rbNaoResolveu.UseVisualStyleBackColor = true;
            // 
            // frmAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.rbNaoResolveu);
            this.Controls.Add(this.rbResolveu);
            this.Controls.Add(this.btnAvaliar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTempoAtendimento);
            this.Controls.Add(this.cmbTempodeEspera);
            this.Controls.Add(this.cmbQualidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAvaliacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avaliação de Atendimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbQualidade;
        private System.Windows.Forms.ComboBox cmbTempodeEspera;
        private System.Windows.Forms.ComboBox cmbTempoAtendimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAvaliar;
        private System.Windows.Forms.RadioButton rbResolveu;
        private System.Windows.Forms.RadioButton rbNaoResolveu;
    }
}