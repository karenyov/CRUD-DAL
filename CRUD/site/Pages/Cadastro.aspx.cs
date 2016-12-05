using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCadastrarCliente(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();

                p.nome = txtNome.Text;
                p.endereco = txtEndereco.Text;
                p.email = txtEmail.Text;

                PessoaDAL d = new PessoaDAL();
                d.inserir(p);

                lblMensagem.Text = "Pessoa "+p.nome+" cadastrada com sucesso.";
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}