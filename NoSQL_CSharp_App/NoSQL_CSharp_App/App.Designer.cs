namespace NoSQL_CSharp_App
{
    partial class App
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Nome = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lb_Idade = new System.Windows.Forms.Label();
            this.tb_Idade = new System.Windows.Forms.TextBox();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nome.Location = new System.Drawing.Point(12, 29);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(67, 24);
            this.lb_Nome.TabIndex = 0;
            this.lb_Nome.Text = "Nome:";
            this.lb_Nome.Click += new System.EventHandler(this.lb_Nome_Click);
            // 
            // tb_Nome
            // 
            this.tb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nome.Location = new System.Drawing.Point(85, 26);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(197, 29);
            this.tb_Nome.TabIndex = 1;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(12, 94);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(68, 24);
            this.lb_Email.TabIndex = 2;
            this.lb_Email.Text = "E-Mail:";
            this.lb_Email.Click += new System.EventHandler(this.lb_Email_Click);
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(85, 91);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(416, 29);
            this.tb_Email.TabIndex = 3;
            // 
            // lb_Idade
            // 
            this.lb_Idade.AutoSize = true;
            this.lb_Idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Idade.Location = new System.Drawing.Point(333, 31);
            this.lb_Idade.Name = "lb_Idade";
            this.lb_Idade.Size = new System.Drawing.Size(62, 24);
            this.lb_Idade.TabIndex = 4;
            this.lb_Idade.Text = "Idade:";
            this.lb_Idade.Click += new System.EventHandler(this.lb_Idade_Click);
            // 
            // tb_Idade
            // 
            this.tb_Idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Idade.Location = new System.Drawing.Point(401, 29);
            this.tb_Idade.Name = "tb_Idade";
            this.tb_Idade.Size = new System.Drawing.Size(100, 29);
            this.tb_Idade.TabIndex = 5;
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enviar.Location = new System.Drawing.Point(203, 150);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(164, 77);
            this.btn_Enviar.TabIndex = 6;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.tb_Idade);
            this.Controls.Add(this.lb_Idade);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.lb_Nome);
            this.Name = "App";
            this.Text = "App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lb_Idade;
        private System.Windows.Forms.TextBox tb_Idade;
        private System.Windows.Forms.Button btn_Enviar;
    }
}

