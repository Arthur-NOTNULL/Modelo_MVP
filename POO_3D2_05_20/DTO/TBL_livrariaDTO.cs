using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO_3D2_05_20.DTO
{
    public class TBL_livrariaDTO
    {
        private int idLivro, idAutor, idEditora;
        private string titulo, NumeroPaginas;
        private DateTime dataCadastro;
        private double valor;

        public int IdLivro { get => idLivro; set => idLivro = value; }
        public int IdAutor { get => idAutor; set => idAutor = value; }
        public int IdEditora { get => idEditora; set => idEditora = value; }

        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }

        public double Valor { get => valor; set => valor = value; }

        public string Titulo
        {
            set
            {
                if (value != string.Empty)
                {
                    this.titulo = value;
                }
                else
                {
                    throw new Exception("O campo 'Título' é obrigatório");
                }

            }
            get { return this.titulo; }

        }

        public string NumeroPaginas
        {
            set
            {
                if (value != string.Empty)
                {
                    this.NumeroPaginas = value;
                }
                else
                {
                    throw new Exception("O campo 'Número de Páginas' é obrigatório");
                }

            }
            get { return this.NumeroPaginas; }

        }
    }
}