using MedidorLibrary.DAL;
using MedidorLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EvaluacionASP_Castro_Osorio_Reyes
{
    public partial class Ingresar : System.Web.UI.Page
    {
        private iMedidor medidorDAL = new MedidorDAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            int idMedidor = Convert.ToInt32(this.txtId.Text.Trim());
            string tipoMedidor = this.tiposRbl.SelectedValue;
            string tipo = medidorDAL.TipoTxt(tipoMedidor);
            Medidor m = new Medidor
            {
                Id = idMedidor,
                Tipo = tipo,
            };
            bool flag = medidorDAL.Filtrar(m);
            if (flag == true)
            {
                this.errorMsg.Text = "Este Medidor ya existe, intente nuevamente";
            }
            else
            {
                medidorDAL.AgregarMedidor(m);
                this.successMsg.Text = "Medidor ingresado correctamente";
                Response.Redirect("VerMedidores.aspx");
            }
        }

    }
}