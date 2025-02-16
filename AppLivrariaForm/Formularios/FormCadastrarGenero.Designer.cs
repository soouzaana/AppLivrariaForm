namespace AppLivrariaForm.Formularios
{
    partial class FormCadastrarGenero
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
            this.label6 = new System.Windows.Forms.Label();
            this.Cursso = new System.Windows.Forms.Label();
            this.Serie = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNomeGenero = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPublicoAlvo = new System.Windows.Forms.TextBox();
            this.txtPopularidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(378, 25);
            this.label6.TabIndex = 83;
            this.label6.Text = "CADASTRAR GÊNERO LITERÁRIO";
            // 
            // Cursso
            // 
            this.Cursso.AutoSize = true;
            this.Cursso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cursso.Location = new System.Drawing.Point(22, 150);
            this.Cursso.Name = "Cursso";
            this.Cursso.Size = new System.Drawing.Size(110, 18);
            this.Cursso.TabIndex = 80;
            this.Cursso.Text = "DESCRIÇÃO:";
            // 
            // Serie
            // 
            this.Serie.AutoSize = true;
            this.Serie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serie.Location = new System.Drawing.Point(18, 76);
            this.Serie.Name = "Serie";
            this.Serie.Size = new System.Drawing.Size(63, 18);
            this.Serie.TabIndex = 78;
            this.Serie.Text = "NOME:";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Red;
            this.btCancelar.CausesValidation = false;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCancelar.Location = new System.Drawing.Point(355, 234);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(189, 38);
            this.btCancelar.TabIndex = 77;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(21, 171);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(279, 31);
            this.txtDescricao.TabIndex = 75;
            // 
            // txtNomeGenero
            // 
            this.txtNomeGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeGenero.Location = new System.Drawing.Point(21, 97);
            this.txtNomeGenero.Name = "txtNomeGenero";
            this.txtNomeGenero.Size = new System.Drawing.Size(279, 31);
            this.txtNomeGenero.TabIndex = 74;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btSalvar.CausesValidation = false;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSalvar.Location = new System.Drawing.Point(355, 166);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(189, 38);
            this.btSalvar.TabIndex = 73;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 87;
            this.label1.Text = "PÚBLICO-ALVO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 86;
            this.label2.Text = "POPULARIDADE:";
            // 
            // txtPublicoAlvo
            // 
            this.txtPublicoAlvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublicoAlvo.Location = new System.Drawing.Point(23, 314);
            this.txtPublicoAlvo.Name = "txtPublicoAlvo";
            this.txtPublicoAlvo.Size = new System.Drawing.Size(279, 31);
            this.txtPublicoAlvo.TabIndex = 85;
            // 
            // txtPopularidade
            // 
            this.txtPopularidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPopularidade.Location = new System.Drawing.Point(23, 240);
            this.txtPopularidade.Name = "txtPopularidade";
            this.txtPopularidade.Size = new System.Drawing.Size(279, 31);
            this.txtPopularidade.TabIndex = 84;
            // 
            // FormCadastrarGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPublicoAlvo);
            this.Controls.Add(this.txtPopularidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cursso);
            this.Controls.Add(this.Serie);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNomeGenero);
            this.Controls.Add(this.btSalvar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCadastrarGenero";
            this.Text = "FormCadastrarGenero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Cursso;
        private System.Windows.Forms.Label Serie;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNomeGenero;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPublicoAlvo;
        private System.Windows.Forms.TextBox txtPopularidade;
    }
}