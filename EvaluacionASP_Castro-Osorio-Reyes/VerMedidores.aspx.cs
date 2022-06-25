using MedidorLibrary.DAL;
using MedidorLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EvaluacionASP_Castro_Osorio_Reyes
{
    public partial class VerMedidores : System.Web.UI.Page
    {
        private iMedidor medidoresDAL = new MedidorDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            this.gridMedidores.DataSource = medidoresDAL.ObtenerMedidores();
            this.gridMedidores.DataBind();
        }

        protected void dplFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = this.dplFiltro.SelectedValue;
            string dato = medidoresDAL.TipoTxt(tipo);
            List<Medidor> listaFiltrada = medidoresDAL.FiltradoTipo(dato);
            this.gridMedidores.DataSource = listaFiltrada;
            this.gridMedidores.DataBind();
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }
    }
}