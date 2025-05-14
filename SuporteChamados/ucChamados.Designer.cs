namespace SuporteChamados
{
    partial class ucChamados
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbID = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbPrioridade = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbNivel = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(13, 13);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(60, 25);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "1001";
            // 
            // lbTitulo
            // 
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(94, 13);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(276, 25);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Erro ao acessar o sistema";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(376, 13);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(158, 25);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Em Andamento";
            // 
            // lbPrioridade
            // 
            this.lbPrioridade.AutoSize = true;
            this.lbPrioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrioridade.Location = new System.Drawing.Point(540, 13);
            this.lbPrioridade.Name = "lbPrioridade";
            this.lbPrioridade.Size = new System.Drawing.Size(88, 25);
            this.lbPrioridade.TabIndex = 3;
            this.lbPrioridade.Text = "Urgente";
            // 
            // lbCategoria
            // 
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(634, 13);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(150, 25);
            this.lbCategoria.TabIndex = 4;
            this.lbCategoria.Text = "Software";
            // 
            // lbNivel
            // 
            this.lbNivel.AutoSize = true;
            this.lbNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNivel.Location = new System.Drawing.Point(790, 13);
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.Size = new System.Drawing.Size(24, 25);
            this.lbNivel.TabIndex = 5;
            this.lbNivel.Text = "4";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(820, 13);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(210, 25);
            this.lbData.TabIndex = 6;
            this.lbData.Text = "14/01/2025 09:00:00";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Location = new System.Drawing.Point(1036, 13);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(61, 25);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // ucChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbNivel);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbPrioridade);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lbID);
            this.Name = "ucChamados";
            this.Size = new System.Drawing.Size(1100, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbPrioridade;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbNivel;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Button btnVisualizar;
    }
}
