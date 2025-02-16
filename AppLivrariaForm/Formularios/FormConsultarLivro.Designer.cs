namespace AppLivrariaForm.Formularios
{
    partial class FormConsultarLivro
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
            this.dtTabela = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cursso = new System.Windows.Forms.Label();
            this.Serie = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNomeGenero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTabela
            // 
            this.dtTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTabela.Location = new System.Drawing.Point(13, 389);
            this.dtTabela.Margin = new System.Windows.Forms.Padding(4);
            this.dtTabela.Name = "dtTabela";
            this.dtTabela.RowHeadersWidth = 51;
            this.dtTabela.Size = new System.Drawing.Size(764, 359);
            this.dtTabela.TabIndex = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(13, 335);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 16);
            this.panel1.TabIndex = 69;
            // 
            // cbGenero
            // 
            this.cbGenero.CausesValidation = false;
            this.cbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(86, 101);
            this.cbGenero.Margin = new System.Windows.Forms.Padding(4);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(640, 33);
            this.cbGenero.TabIndex = 64;
            this.cbGenero.SelectedIndexChanged += new System.EventHandler(this.cbGenero_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(508, 31);
            this.label6.TabIndex = 63;
            this.label6.Text = "CONSULTAR LIVROS POR GÊNERO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(242, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 24);
            this.label5.TabIndex = 62;
            this.label5.Text = "SELECIONE O GÊNERO:";
            // 
            // Cursso
            // 
            this.Cursso.AutoSize = true;
            this.Cursso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cursso.Location = new System.Drawing.Point(88, 246);
            this.Cursso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cursso.Name = "Cursso";
            this.Cursso.Size = new System.Drawing.Size(134, 24);
            this.Cursso.TabIndex = 84;
            this.Cursso.Text = "DESCRIÇÃO:";
            // 
            // Serie
            // 
            this.Serie.AutoSize = true;
            this.Serie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serie.Location = new System.Drawing.Point(82, 155);
            this.Serie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Serie.Name = "Serie";
            this.Serie.Size = new System.Drawing.Size(78, 24);
            this.Serie.TabIndex = 83;
            this.Serie.Text = "NOME:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(86, 272);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(640, 37);
            this.txtDescricao.TabIndex = 82;
            // 
            // txtNomeGenero
            // 
            this.txtNomeGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeGenero.Location = new System.Drawing.Point(86, 180);
            this.txtNomeGenero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeGenero.Name = "txtNomeGenero";
            this.txtNomeGenero.Size = new System.Drawing.Size(640, 37);
            this.txtNomeGenero.TabIndex = 81;
            // 
            // FormConsultarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 754);
            this.Controls.Add(this.Cursso);
            this.Controls.Add(this.Serie);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNomeGenero);
            this.Controls.Add(this.dtTabela);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "FormConsultarLivro";
            this.Text = "FormConsultarLivro";
            ((System.ComponentModel.ISupportInitialize)(this.dtTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtTabela;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Cursso;
        private System.Windows.Forms.Label Serie;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNomeGenero;
    }
}