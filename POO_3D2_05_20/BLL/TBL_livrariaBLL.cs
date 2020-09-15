using POO_3D2_05_20.DAL;
using POO_3D2_05_20.DTO;
using POO_3D2_05_20.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace POO_3D2_05_20.BLL
{
    public class TBL_livrariaBLL
    {
        private DAL_livraria daoBanco = new DAL_livraria();

        

        public DataTable Listarlivros()
        {
            string sql = string.Format($@"select * from TBL_Livro");
            return daoBanco.executarConsulta(sql);
        }

        
        public void Inserirlivro(TBL_livrariaDTO dtolivros)
        {
            string sql = string.Format($@"INSERT INTO TBL_Livro VALUES (NULL,'{dtolivros.IdAutor}',
                                                                               '{dtolivros.IdEditora}',   
                                                                               '{dtolivros.Titulo}',
                                                                               '{dtolivros.DataCadastro}',
                                                                               '{dtolivros.num_Paginas}',
                                                                               '{dtolivros.Valor}');");
            daoBanco.executarComando(sql);

        }

         public void AlterarLivro(TBL_livrariaDTO dtolivros)
        {
            string sql = string.Format($@"UPDATE TBL_Livro set idAutor = '{dtolivros.IdAutor}',
                                                                 idEditora  = '{dtolivros.IdEditora}',
                                                                 titulo  = '{dtolivros.Titulo}',
                                                                 dataCadastro  = '{dtolivros.DataCadastro}'
                                                                 numPaginas  = '{dtolivros.num_Paginas}'
                                                                 valor  = '{dtolivros.Valor}'
                                                where idLivro = '{dtolivros.IdLivro}';");
            daoBanco.executarComando(sql);

        }

       
        public void ExcluirLivro(TBL_livrariaDTO dtolivros)
        {
            string sql = string.Format($@"DELETE FROM TBL_Livro where idLivro = {dtolivros.IdLivro};");
            daoBanco.executarComando(sql);
        }
    }
    
}