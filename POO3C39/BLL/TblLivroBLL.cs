using POO3C39.DAL;
using POO3C39.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3C39.BLL
{
    class TblLivroBLL
    {
        private DALMysql DaoBanco = new DALMysql();

        public DataTable ListarTodos()
        {
            string sql = string.Format($@"select * from tbl_livro");
            return DaoBanco.executarConsulta(sql);
        }
        public void Alterar(TblLivroDTO dtoLivro)
        {
            string sql = string.Format($@"UPDATE tbl_livro set idAutor = '{dtoLivro.IdAutor}',idEditora = '{dtoLivro.IdEditora}',titulo = '{dtoLivro.Titulo}',dataCadastro = '{dtoLivro.DataCadastro}',numPaginas = '{dtoLivro.NumPaginas}', valor = '{dtoLivro.Valor}' where idLivro = '{dtoLivro.IdLivro}';");
            DaoBanco.executarComando(sql);

        }

        public void Inserir(TblLivroDTO ObjLivro)
        {
            string sql = string.Format($@"INSERT INTO tbl_livro VALUES (NULL,'{ObjLivro.IdAutor}',
                                                                             '{ObjLivro.IdEditora}',  
                                                                             '{ObjLivro.Titulo}',
                                                                             '{ObjLivro.DataCadastro}',
                                                                             '{ObjLivro.NumPaginas}',
                                                                             '{ObjLivro.Valor}');");
            DaoBanco.executarComando(sql);


        }

        public void Excluir(TblLivroDTO objLivro)
        {
            string sql = string.Format($@"DELETE FROM tbl_livro where id = {objLivro.IdLivro};");
            DaoBanco.executarComando(sql);
        }

        public DataTable Pesquisar(string condicao)
        {
            string sql = string.Format($@"select * from tbl_livro where " + condicao);
            return DaoBanco.executarConsulta(sql);
        }
    }
}
