namespace POO3C39
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
            this.GridLivros = new System.Windows.Forms.DataGridView();
            this.GridEditora = new System.Windows.Forms.DataGridView();
            this.GridAutor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idLivro = new System.Windows.Forms.TextBox();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_idAutor = new System.Windows.Forms.TextBox();
            this.txt_DataDeCadastro = new System.Windows.Forms.TextBox();
            this.txt_idEditora = new System.Windows.Forms.TextBox();
            this.txt_numPaginas = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_busca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEditora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // GridLivros
            // 
            this.GridLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLivros.Location = new System.Drawing.Point(12, 14);
            this.GridLivros.Name = "GridLivros";
            this.GridLivros.Size = new System.Drawing.Size(240, 124);
            this.GridLivros.TabIndex = 0;
            this.GridLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridLivros_CellContentClick);
            // 
            // GridEditora
            // 
            this.GridEditora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEditora.Location = new System.Drawing.Point(12, 165);
            this.GridEditora.Name = "GridEditora";
            this.GridEditora.Size = new System.Drawing.Size(240, 124);
            this.GridEditora.TabIndex = 1;
            // 
            // GridAutor
            // 
            this.GridAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAutor.Location = new System.Drawing.Point(12, 322);
            this.GridAutor.Name = "GridAutor";
            this.GridAutor.Size = new System.Drawing.Size(240, 124);
            this.GridAutor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Livros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Editora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autor";
            // 
            // txt_idLivro
            // 
            this.txt_idLivro.Enabled = false;
            this.txt_idLivro.Location = new System.Drawing.Point(268, 24);
            this.txt_idLivro.Name = "txt_idLivro";
            this.txt_idLivro.Size = new System.Drawing.Size(100, 20);
            this.txt_idLivro.TabIndex = 6;
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(396, 24);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(100, 20);
            this.txt_titulo.TabIndex = 7;
            // 
            // txt_idAutor
            // 
            this.txt_idAutor.Location = new System.Drawing.Point(268, 65);
            this.txt_idAutor.Name = "txt_idAutor";
            this.txt_idAutor.Size = new System.Drawing.Size(100, 20);
            this.txt_idAutor.TabIndex = 8;
            // 
            // txt_DataDeCadastro
            // 
            this.txt_DataDeCadastro.Location = new System.Drawing.Point(396, 65);
            this.txt_DataDeCadastro.Name = "txt_DataDeCadastro";
            this.txt_DataDeCadastro.Size = new System.Drawing.Size(100, 20);
            this.txt_DataDeCadastro.TabIndex = 9;
            // 
            // txt_idEditora
            // 
            this.txt_idEditora.Location = new System.Drawing.Point(268, 102);
            this.txt_idEditora.Name = "txt_idEditora";
            this.txt_idEditora.Size = new System.Drawing.Size(100, 20);
            this.txt_idEditora.TabIndex = 10;
            // 
            // txt_numPaginas
            // 
            this.txt_numPaginas.Location = new System.Drawing.Point(396, 102);
            this.txt_numPaginas.Name = "txt_numPaginas";
            this.txt_numPaginas.Size = new System.Drawing.Size(100, 20);
            this.txt_numPaginas.TabIndex = 11;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(396, 141);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Id Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Id Livro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Id Editora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Titulo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Data Cadastro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "N. Paginas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(393, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Valor";
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(396, 167);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(100, 23);
            this.btn_inserir.TabIndex = 20;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(396, 196);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(100, 23);
            this.btn_excluir.TabIndex = 21;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(396, 225);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(100, 23);
            this.btn_editar.TabIndex = 22;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(396, 254);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(100, 23);
            this.btn_sair.TabIndex = 23;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(332, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Eduardo Rodrigues - 8";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(332, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Tales Henrique - 31";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(268, 141);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(100, 20);
            this.txt_pesquisa.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(265, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Pesquisa";
            // 
            // btn_busca
            // 
            this.btn_busca.Location = new System.Drawing.Point(268, 165);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(100, 23);
            this.btn_busca.TabIndex = 28;
            this.btn_busca.Text = "Pesquisar";
            this.btn_busca.UseVisualStyleBackColor = true;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 458);
            this.Controls.Add(this.btn_busca);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_numPaginas);
            this.Controls.Add(this.txt_idEditora);
            this.Controls.Add(this.txt_DataDeCadastro);
            this.Controls.Add(this.txt_idAutor);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.txt_idLivro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridAutor);
            this.Controls.Add(this.GridEditora);
            this.Controls.Add(this.GridLivros);
            this.Name = "Form1";
            this.Text = "Livraria";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEditora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridLivros;
        private System.Windows.Forms.DataGridView GridEditora;
        private System.Windows.Forms.DataGridView GridAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_idLivro;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_idAutor;
        private System.Windows.Forms.TextBox txt_DataDeCadastro;
        private System.Windows.Forms.TextBox txt_idEditora;
        private System.Windows.Forms.TextBox txt_numPaginas;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_busca;
    }
}

