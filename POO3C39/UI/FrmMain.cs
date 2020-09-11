using System;
using POO3C39.BLL;
using POO3C39.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO3C39
{
    public partial class Form1 : Form
    {
        tblAutorBLL bllAutor = new tblAutorBLL();
        TblAutorDTO dtoAutor = new TblAutorDTO();
        TblEditoraBLL bllEditora= new TblEditoraBLL();
        TblEditoraDTO dtoEditora = new TblEditoraDTO();
        TblLivroBLL bllLivro= new TblLivroBLL();
        TblLivroDTO dtoLivro = new TblLivroDTO();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridAutor.DataSource = bllAutor.ListarTodos();
            GridEditora.DataSource = bllEditora.ListarTodos();
            GridLivros.DataSource = bllLivro.ListarTodos();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                dtoLivro.IdAutor = int.Parse(txt_idAutor.Text);
                dtoLivro.IdEditora = int.Parse(txt_idEditora.Text);
                dtoLivro.Titulo = txt_titulo.Text.ToString();
                dtoLivro.DataCadastro = txt_DataDeCadastro.Text.ToString();
                dtoLivro.NumPaginas = int.Parse(txt_numPaginas.Text.ToString());
                dtoLivro.Valor = int.Parse(txt_valor.Text.ToString());


                bllLivro.Inserir(dtoLivro);
                MessageBox.Show("Livro inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridLivros.DataSource = bllLivro.ListarTodos();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Está ação irá deletar o livro selecionado e não poderá ser desfeito! deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    dtoLivro.IdLivro = Convert.ToInt32(txt_idLivro.Text);
                    bllLivro.Excluir(dtoLivro);
                    GridLivros.DataSource = bllLivro.ListarTodos();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                dtoLivro.IdLivro = int.Parse(txt_idLivro.Text);
                dtoLivro.IdEditora = int.Parse(txt_idEditora.Text.ToString());
                dtoLivro.IdAutor = int.Parse(txt_idAutor.Text.ToString());
                dtoLivro.Titulo = txt_titulo.Text.ToString();
                dtoLivro.DataCadastro = txt_DataDeCadastro.Text.ToString();
                dtoLivro.NumPaginas = int.Parse(txt_numPaginas.Text);
                dtoLivro.Valor = int.Parse(txt_valor.Text);

                bllLivro.Alterar(dtoLivro);
                MessageBox.Show("Alteração Feita com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridLivros.DataSource = bllLivro.ListarTodos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idLivro.Text = GridLivros.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_idAutor.Text = GridLivros.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_idEditora.Text = GridLivros.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_titulo.Text = GridLivros.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_DataDeCadastro.Text = GridLivros.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_numPaginas.Text = GridLivros.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_valor.Text = GridLivros.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            string condicao = "titulo like '%" + txt_pesquisa.Text + "%'";

            ;
            GridLivros.DataSource = bllLivro.Pesquisar(condicao);
        }
    }
}
