namespace SuporteChamados
{
    partial class frmCriarChamado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtTituloTicket = new System.Windows.Forms.TextBox();
            this.txtDescricaoTicket = new System.Windows.Forms.TextBox();
            this.cbPrioridadeTicket = new System.Windows.Forms.ComboBox();
            this.cbCategoriaTicket = new System.Windows.Forms.ComboBox();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Novo Ticket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(251, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Prioridade";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(549, 417);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(123, 32);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtTituloTicket
            // 
            this.txtTituloTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloTicket.Location = new System.Drawing.Point(17, 91);
            this.txtTituloTicket.Name = "txtTituloTicket";
            this.txtTituloTicket.Size = new System.Drawing.Size(655, 29);
            this.txtTituloTicket.TabIndex = 8;
            // 
            // txtDescricaoTicket
            // 
            this.txtDescricaoTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoTicket.Location = new System.Drawing.Point(17, 171);
            this.txtDescricaoTicket.Multiline = true;
            this.txtDescricaoTicket.Name = "txtDescricaoTicket";
            this.txtDescricaoTicket.Size = new System.Drawing.Size(655, 149);
            this.txtDescricaoTicket.TabIndex = 9;
            // 
            // cbPrioridadeTicket
            // 
            this.cbPrioridadeTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrioridadeTicket.FormattingEnabled = true;
            this.cbPrioridadeTicket.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta",
            "Urgente"});
            this.cbPrioridadeTicket.Location = new System.Drawing.Point(17, 370);
            this.cbPrioridadeTicket.Name = "cbPrioridadeTicket";
            this.cbPrioridadeTicket.Size = new System.Drawing.Size(177, 32);
            this.cbPrioridadeTicket.TabIndex = 10;
            // 
            // cbCategoriaTicket
            // 
            this.cbCategoriaTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaTicket.FormattingEnabled = true;
            this.cbCategoriaTicket.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "Rede",
            "Conta",
            "Segurança",
            "Solicitações Gerais",
            "Outro"});
            this.cbCategoriaTicket.Location = new System.Drawing.Point(256, 370);
            this.cbCategoriaTicket.Name = "cbCategoriaTicket";
            this.cbCategoriaTicket.Size = new System.Drawing.Size(177, 32);
            this.cbCategoriaTicket.TabIndex = 11;
            // 
            // cbNivel
            // 
            this.cbNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbNivel.Location = new System.Drawing.Point(495, 370);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(177, 32);
            this.cbNivel.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(490, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nível";
            // 
            // frmCriarChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.cbNivel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCategoriaTicket);
            this.Controls.Add(this.cbPrioridadeTicket);
            this.Controls.Add(this.txtDescricaoTicket);
            this.Controls.Add(this.txtTituloTicket);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCriarChamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Chamado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtTituloTicket;
        private System.Windows.Forms.TextBox txtDescricaoTicket;
        private System.Windows.Forms.ComboBox cbPrioridadeTicket;
        private System.Windows.Forms.ComboBox cbCategoriaTicket;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.Label label6;
    }
}