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
    class tblAutorBLL
    {
        private DALMysql DaoBanco = new DALMysql();
        
        public DataTable ListarTodos()
        {
            string sql = string.Format($@"select * from tbl_autor");
            return DaoBanco.executarConsulta(sql);
        }
        public void Alterar(TblAutorDTO dtoAutor)
        {
            string sql = string.Format($@"UPDATE tbl_autor set nome = '{dtoAutor.Nome}',
                                                               idade = '{dtoAutor.Idade}'                                                                                                                              
                                                               where id = '{dtoAutor.IdAutor}';");
            DaoBanco.executarComando(sql);

        }

        public void Inserir(TblAutorDTO ObjAutor)
        {
            string sql = string.Format($@"INSERT INTO tbl_autor VALUES (NULL,'{ObjAutor.Nome}',                                                                          
                                                                          '{ObjAutor.Idade}');");
            DaoBanco.executarComando(sql);


        }

        public void Excluir(TblAutorDTO objAutor)
        {
            string sql = string.Format($@"DELETE FROM tbl_autor where id = {objAutor.IdAutor};");
            DaoBanco.executarComando(sql);
        }

        
    }
}
