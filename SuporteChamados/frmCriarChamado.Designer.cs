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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnListagemDeChamados = new System.Windows.Forms.Button();
            this.btnCriarChamado = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.btnListagemDeChamados);
            this.panel1.Controls.Add(this.btnCriarChamado);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 761);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SuporteChamados.Properties.Resources.Design_sem_nome;
            this.pictureBox5.Location = new System.Drawing.Point(12, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(345, 110);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // btnListagemDeChamados
            // 
            this.btnListagemDeChamados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListagemDeChamados.Location = new System.Drawing.Point(13, 235);
            this.btnListagemDeChamados.Name = "btnListagemDeChamados";
            this.btnListagemDeChamados.Size = new System.Drawing.Size(344, 43);
            this.btnListagemDeChamados.TabIndex = 6;
            this.btnListagemDeChamados.Text = "Listagem de chamados";
            this.btnListagemDeChamados.UseVisualStyleBackColor = true;
            // 
            // btnCriarChamado
            // 
            this.btnCriarChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarChamado.Location = new System.Drawing.Point(13, 186);
            this.btnCriarChamado.Name = "btnCriarChamado";
            this.btnCriarChamado.Size = new System.Drawing.Size(344, 43);
            this.btnCriarChamado.TabIndex = 5;
            this.btnCriarChamado.Text = "Criar chamado";
            this.btnCriarChamado.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(13, 137);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(344, 43);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(378, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Novo Ticket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(381, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(381, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(384, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(381, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "Prioridade";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(1122, 679);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(250, 70);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // txtTituloTicket
            // 
            this.txtTituloTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloTicket.Location = new System.Drawing.Point(388, 157);
            this.txtTituloTicket.Name = "txtTituloTicket";
            this.txtTituloTicket.Size = new System.Drawing.Size(667, 44);
            this.txtTituloTicket.TabIndex = 8;
            // 
            // txtDescricaoTicket
            // 
            this.txtDescricaoTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoTicket.Location = new System.Drawing.Point(388, 263);
            this.txtDescricaoTicket.Multiline = true;
            this.txtDescricaoTicket.Name = "txtDescricaoTicket";
            this.txtDescricaoTicket.Size = new System.Drawing.Size(667, 125);
            this.txtDescricaoTicket.TabIndex = 9;
            // 
            // cbPrioridadeTicket
            // 
            this.cbPrioridadeTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrioridadeTicket.FormattingEnabled = true;
            this.cbPrioridadeTicket.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta",
            "Urgente"});
            this.cbPrioridadeTicket.Location = new System.Drawing.Point(388, 452);
            this.cbPrioridadeTicket.Name = "cbPrioridadeTicket";
            this.cbPrioridadeTicket.Size = new System.Drawing.Size(216, 45);
            this.cbPrioridadeTicket.TabIndex = 10;
            // 
            // cbCategoriaTicket
            // 
            this.cbCategoriaTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaTicket.FormattingEnabled = true;
            this.cbCategoriaTicket.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "Rede",
            "Conta",
            "Segurança",
            "Solicitações Gerais",
            "Outro"});
            this.cbCategoriaTicket.Location = new System.Drawing.Point(391, 558);
            this.cbCategoriaTicket.Name = "cbCategoriaTicket";
            this.cbCategoriaTicket.Size = new System.Drawing.Size(216, 45);
            this.cbCategoriaTicket.TabIndex = 11;
            // 
            // cbNivel
            // 
            this.cbNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbNivel.Location = new System.Drawing.Point(391, 664);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(216, 45);
            this.cbNivel.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(384, 624);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nível";
            // 
            // frmCriarChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1384, 761);
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
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCriarChamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Chamado";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListagemDeChamados;
        private System.Windows.Forms.Button btnCriarChamado;
        private System.Windows.Forms.Button btnDashboard;
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
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.Label label6;
    }
}