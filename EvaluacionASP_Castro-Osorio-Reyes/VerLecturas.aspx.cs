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
    public partial class VerLecturas : System.Web.UI.Page
    {
        private iLectura lecturasDAL = new LecturaDAL();
        private iMedidor medidoresDAL = new MedidorDAL();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
            cargaDrop(medidores);
            cargarGrilla();
        }
        private void cargaDrop(List<Medidor> medidores)
        {
            for (int i = 0; i < medidores.Count; i++)
            {
                Medidor actual = medidores[i];
                ListItem listitem;
                string idList = Convert.ToString(actual.Id);
                listitem = new ListItem(idList);
                dplMedidor.Items.Add(listitem);
            }
        }
        private void cargarGrilla()
        {
            this.gridLecturas.DataSource = lecturasDAL.ObtenerLecturas();
            this.gridLecturas.DataBind();
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        protected void dplMedidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dplMedidor.SelectedValue);
            List<Lectura> listaFiltrada = lecturasDAL.FiltrarLectura(id);
            this.gridLecturas.DataSource = listaFiltrada;
            this.gridLecturas.DataBind();
        }
    }
}