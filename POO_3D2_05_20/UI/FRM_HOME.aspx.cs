using POO_3D2_05_20.BLL;
using POO_3D2_05_20.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POO_3D2_05_20.UI
{
    public partial class FRM_HOME : System.Web.UI.Page
    {
         TBL_livrariaBLL blllivraria = new TBL_livrariaBLL();
        TBL_livrariaDTO dtolivraria = new TBL_livrariaDTO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Validate();
                this.ExibirGridLivraria();
            }
        }

        protected void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                dtolivraria.IdAutor = int.Parse(txtautor.Text);
                dtolivraria.IdEditora = int.Parse(txteditora.Text);
                dtolivraria.Titulo = txttitulo.Text;
                dtolivraria.DataCadastro = DateTime.Parse(txtdatacadastro.Text);
                dtolivraria.NumeroPaginas = int.Parse(txtnumpaginas.Text);
                dtolivraria.Valor = double.Parse(txtvalor.Text);

                
                blllivraria.Inserirlivro(dtolivraria);
                msgerro.Visible = true;
                msgerro.Text = "Livro Cadastrado com Sucesso";
                this.LimparCampos();
                this.ExibirGridLivraria();
            }
            catch(Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }

        }

        public void ExibirGridLivraria()
        {
            GridLivraria.DataSource = blllivraria.Listarlivros();
            GridLivraria.DataBind();
        }

        protected void GridLivros_RowDeleting(object sender, GridViewDeleteEventArgs Registro)
        {
            try
            {
                dtolivraria.Id_Livro = Convert.ToInt32(Registro.Values[0]);
                blllivraria.ExcluirLivro(dtolivraria);
                this.ExibirGridLivraria();
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }
        public void LimparCampos()
        {
            txtautor.Text = "";
            txteditora.Text = "";
            txttitulo.Text = "";
            txtnumpaginas.Text = "";
            txtvalor.Text = "";
            txtdatacadastro.Text = "";
        }

        
        protected void GridLivros_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridLivraria.EditIndex = e.NewEditIndex;
            this.ExibirGridLivraria();
        }
        
        protected void GridLivros_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                dtolivraria.Titulo = e.NewValues[3].ToString();
                dtolivraria.NumeroPaginas = e.NewValues[4].ToString();
                dtolivraria.Valor = Double.Parse(e.NewValues[5].ToString());
                blllivraria.AlterarLivro(dtolivraria);
                GridLivraria.EditIndex = -1;
                this.ExibirGridLivraria();
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }
        protected void GridLivraria_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridLivraria.EditIndex = -1;
            this.ExibirGridLivraria();
        }

        protected void GridLivraria_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridLivraria.PageIndex = e.NewPageIndex;
            this.ExibirGridLivraria();
        }
    }
    
}