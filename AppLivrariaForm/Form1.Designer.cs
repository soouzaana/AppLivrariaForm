namespace AppLivrariaForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btCadastrarLivro = new System.Windows.Forms.Button();
            this.btCadastrarGenero = new System.Windows.Forms.Button();
            this.btListarLivros = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btListarGeneros = new System.Windows.Forms.Button();
            this.btCadastrarAutor = new System.Windows.Forms.Button();
            this.btListarAutores = new System.Windows.Forms.Button();
            this.btGerenciarAutor = new System.Windows.Forms.Button();
            this.btPesquisarAutor = new System.Windows.Forms.Button();
            this.btGerenciarGenero = new System.Windows.Forms.Button();
            this.btPesquisarGenero = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btConsultarLivro = new System.Windows.Forms.Button();
            this.btGerenciarLivro = new System.Windows.Forms.Button();
            this.btPesquisarLivro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(26, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Alunos: Ana Maria, Emanueli, Luis Miguel e Mariana";
            // 
            // btCadastrarLivro
            // 
            this.btCadastrarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarLivro.Location = new System.Drawing.Point(691, 145);
            this.btCadastrarLivro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCadastrarLivro.Name = "btCadastrarLivro";
            this.btCadastrarLivro.Size = new System.Drawing.Size(291, 62);
            this.btCadastrarLivro.TabIndex = 8;
            this.btCadastrarLivro.Text = "CADASTRAR LIVRO";
            this.btCadastrarLivro.UseVisualStyleBackColor = true;
            this.btCadastrarLivro.Click += new System.EventHandler(this.btCadastrarLivro_Click);
            // 
            // btCadastrarGenero
            // 
            this.btCadastrarGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarGenero.Location = new System.Drawing.Point(13, 145);
            this.btCadastrarGenero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCadastrarGenero.Name = "btCadastrarGenero";
            this.btCadastrarGenero.Size = new System.Drawing.Size(291, 62);
            this.btCadastrarGenero.TabIndex = 11;
            this.btCadastrarGenero.Text = "CADASTRAR GÊNERO";
            this.btCadastrarGenero.UseVisualStyleBackColor = true;
            this.btCadastrarGenero.Click += new System.EventHandler(this.btCadastrarGenero_Click);
            // 
            // btListarLivros
            // 
            this.btListarLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarLivros.Location = new System.Drawing.Point(691, 217);
            this.btListarLivros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btListarLivros.Name = "btListarLivros";
            this.btListarLivros.Size = new System.Drawing.Size(291, 62);
            this.btListarLivros.TabIndex = 12;
            this.btListarLivros.Text = "LISTAR LIVROS";
            this.btListarLivros.UseVisualStyleBackColor = true;
            this.btListarLivros.Click += new System.EventHandler(this.btListarLivros_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 38);
            this.label2.TabIndex = 13;
            this.label2.Text = "SISTEMA DE LIVRARIA";
            // 
            // btListarGeneros
            // 
            this.btListarGeneros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarGeneros.Location = new System.Drawing.Point(13, 217);
            this.btListarGeneros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btListarGeneros.Name = "btListarGeneros";
            this.btListarGeneros.Size = new System.Drawing.Size(291, 62);
            this.btListarGeneros.TabIndex = 15;
            this.btListarGeneros.Text = "LISTAR GÊNEROS";
            this.btListarGeneros.UseVisualStyleBackColor = true;
            this.btListarGeneros.Click += new System.EventHandler(this.btListarGeneros_Click);
            // 
            // btCadastrarAutor
            // 
            this.btCadastrarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarAutor.Location = new System.Drawing.Point(350, 145);
            this.btCadastrarAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCadastrarAutor.Name = "btCadastrarAutor";
            this.btCadastrarAutor.Size = new System.Drawing.Size(291, 62);
            this.btCadastrarAutor.TabIndex = 17;
            this.btCadastrarAutor.Text = "CADASTRAR AUTOR";
            this.btCadastrarAutor.UseVisualStyleBackColor = true;
            this.btCadastrarAutor.Click += new System.EventHandler(this.btCadastrarAutor_Click);
            // 
            // btListarAutores
            // 
            this.btListarAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarAutores.Location = new System.Drawing.Point(350, 217);
            this.btListarAutores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btListarAutores.Name = "btListarAutores";
            this.btListarAutores.Size = new System.Drawing.Size(291, 62);
            this.btListarAutores.TabIndex = 19;
            this.btListarAutores.Text = "LISTAR AUTORES";
            this.btListarAutores.UseVisualStyleBackColor = true;
            this.btListarAutores.Click += new System.EventHandler(this.btListarAutores_Click);
            // 
            // btGerenciarAutor
            // 
            this.btGerenciarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerenciarAutor.Location = new System.Drawing.Point(350, 289);
            this.btGerenciarAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGerenciarAutor.Name = "btGerenciarAutor";
            this.btGerenciarAutor.Size = new System.Drawing.Size(291, 62);
            this.btGerenciarAutor.TabIndex = 20;
            this.btGerenciarAutor.Text = "GERENCIAR AUTOR";
            this.btGerenciarAutor.UseVisualStyleBackColor = true;
            this.btGerenciarAutor.Click += new System.EventHandler(this.btGerenciarAutor_Click);
            // 
            // btPesquisarAutor
            // 
            this.btPesquisarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisarAutor.Location = new System.Drawing.Point(350, 361);
            this.btPesquisarAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPesquisarAutor.Name = "btPesquisarAutor";
            this.btPesquisarAutor.Size = new System.Drawing.Size(291, 62);
            this.btPesquisarAutor.TabIndex = 21;
            this.btPesquisarAutor.Text = "PESQUISAR AUTOR";
            this.btPesquisarAutor.UseVisualStyleBackColor = true;
            this.btPesquisarAutor.Click += new System.EventHandler(this.btPesquisarAutor_Click);
            // 
            // btGerenciarGenero
            // 
            this.btGerenciarGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerenciarGenero.Location = new System.Drawing.Point(13, 289);
            this.btGerenciarGenero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGerenciarGenero.Name = "btGerenciarGenero";
            this.btGerenciarGenero.Size = new System.Drawing.Size(291, 62);
            this.btGerenciarGenero.TabIndex = 22;
            this.btGerenciarGenero.Text = "GERENCIAR GÊNERO";
            this.btGerenciarGenero.UseVisualStyleBackColor = true;
            this.btGerenciarGenero.Click += new System.EventHandler(this.btGerenciarGenero_Click);
            // 
            // btPesquisarGenero
            // 
            this.btPesquisarGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisarGenero.Location = new System.Drawing.Point(13, 361);
            this.btPesquisarGenero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPesquisarGenero.Name = "btPesquisarGenero";
            this.btPesquisarGenero.Size = new System.Drawing.Size(291, 62);
            this.btPesquisarGenero.TabIndex = 23;
            this.btPesquisarGenero.Text = "PESQUISAR GÊNERO";
            this.btPesquisarGenero.UseVisualStyleBackColor = true;
            this.btPesquisarGenero.Click += new System.EventHandler(this.btPesquisarGenero_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(101, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "GÊNERO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(447, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "AUTOR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label5.Location = new System.Drawing.Point(782, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "LIVRO:";
            // 
            // btConsultarLivro
            // 
            this.btConsultarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarLivro.Location = new System.Drawing.Point(691, 289);
            this.btConsultarLivro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btConsultarLivro.Name = "btConsultarLivro";
            this.btConsultarLivro.Size = new System.Drawing.Size(291, 62);
            this.btConsultarLivro.TabIndex = 28;
            this.btConsultarLivro.Text = "CONSULTAR LIVROS POR GÊNERO";
            this.btConsultarLivro.UseVisualStyleBackColor = true;
            this.btConsultarLivro.Click += new System.EventHandler(this.btConsultarLivro_Click);
            // 
            // btGerenciarLivro
            // 
            this.btGerenciarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerenciarLivro.Location = new System.Drawing.Point(691, 361);
            this.btGerenciarLivro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGerenciarLivro.Name = "btGerenciarLivro";
            this.btGerenciarLivro.Size = new System.Drawing.Size(291, 62);
            this.btGerenciarLivro.TabIndex = 29;
            this.btGerenciarLivro.Text = "GERENCIAR LIVRO";
            this.btGerenciarLivro.UseVisualStyleBackColor = true;
            this.btGerenciarLivro.Click += new System.EventHandler(this.btGerenciarLivro_Click);
            // 
            // btPesquisarLivro
            // 
            this.btPesquisarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisarLivro.Location = new System.Drawing.Point(691, 433);
            this.btPesquisarLivro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPesquisarLivro.Name = "btPesquisarLivro";
            this.btPesquisarLivro.Size = new System.Drawing.Size(291, 62);
            this.btPesquisarLivro.TabIndex = 30;
            this.btPesquisarLivro.Text = "PESQUISAR LIVRO";
            this.btPesquisarLivro.UseVisualStyleBackColor = true;
            this.btPesquisarLivro.Click += new System.EventHandler(this.btPesquisarLivro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 540);
            this.Controls.Add(this.btPesquisarLivro);
            this.Controls.Add(this.btGerenciarLivro);
            this.Controls.Add(this.btConsultarLivro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btPesquisarGenero);
            this.Controls.Add(this.btGerenciarGenero);
            this.Controls.Add(this.btPesquisarAutor);
            this.Controls.Add(this.btGerenciarAutor);
            this.Controls.Add(this.btListarAutores);
            this.Controls.Add(this.btCadastrarAutor);
            this.Controls.Add(this.btListarGeneros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btListarLivros);
            this.Controls.Add(this.btCadastrarGenero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCadastrarLivro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrarLivro;
        private System.Windows.Forms.Button btCadastrarGenero;
        private System.Windows.Forms.Button btListarLivros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btListarGeneros;
        private System.Windows.Forms.Button btCadastrarAutor;
        private System.Windows.Forms.Button btListarAutores;
        private System.Windows.Forms.Button btGerenciarAutor;
        private System.Windows.Forms.Button btPesquisarAutor;
        private System.Windows.Forms.Button btGerenciarGenero;
        private System.Windows.Forms.Button btPesquisarGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btConsultarLivro;
        private System.Windows.Forms.Button btGerenciarLivro;
        private System.Windows.Forms.Button btPesquisarLivro;
    }
}

