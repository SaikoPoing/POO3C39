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
    class TblEditoraBLL
    {
        private DALMysql DaoBanco = new DALMysql();

        public DataTable ListarTodos()
        {
            string sql = string.Format($@"select * from tbl_editora");
            return DaoBanco.executarConsulta(sql);
        }
        public void Alterar(TblEditoraDTO dtoEditora)
        {
            string sql = string.Format($@"UPDATE tbl_editora set nome = '{dtoEditora.Nome}',
                                                               endereco = '{dtoEditora.Endereco}',
                                                               UF = '{dtoEditora.UF1}'
                                                               where id = '{dtoEditora.IdEditora}';");
            DaoBanco.executarComando(sql);

        }

        public void Inserir(TblEditoraDTO ObjEditora)
        {
            string sql = string.Format($@"INSERT INTO tbl_editora VALUES (NULL,'{ObjEditora.Nome}', '{ObjEditora.Endereco}',                                                                
                                                                          '{ObjEditora.UF1}');");
            DaoBanco.executarComando(sql);


        }

        public void Excluir(TblEditoraDTO objEditora)
        {
            string sql = string.Format($@"DELETE FROM tbl_editora where id = {objEditora.IdEditora};");
            DaoBanco.executarComando(sql);
        }
    }
}
