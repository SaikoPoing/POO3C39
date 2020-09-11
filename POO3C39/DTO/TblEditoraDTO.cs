using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3C39.DTO
{
    class TblEditoraDTO
    {
        private int idEditora;
        private string nome, endereco, UF;

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O campo Nome é obrigatório.");
                }
            }
            get { return this.nome; }
        }

        public string Endereco
        {
            set
            {
                if (value != string.Empty)
                {
                    this.endereco = value;
                }
                else
                {
                    throw new Exception("O campo Nome é obrigatório.");
                }
            }
            get { return this.endereco; }
        }

        public string UF1
        {
            set
            {
                if (value != string.Empty)
                {
                    this.UF = value;
                }
                else
                {
                    throw new Exception("O campo Nome é obrigatório.");
                }
            }
            get { return this.UF; }
        }

        public int IdEditora { get => idEditora; set => idEditora = value; }
    }
}
