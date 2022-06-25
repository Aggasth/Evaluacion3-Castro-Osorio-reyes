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
    public partial class IngresarLectura : System.Web.UI.Page
    {
        private iLectura lecturasDAL = new LecturaDAL();
        private iMedidor medidorDAL = new MedidorDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Medidor> medidores= medidorDAL.ObtenerMedidores();
            for (int i = 0; i < medidores.Count; i++)
            {
                Medidor actual = medidores[i];
                ListItem listitem;
                string idList = Convert.ToString(actual.Id);
                listitem = new ListItem(idList);
                dplMedidores.Items.Add(listitem);
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dplMedidores.SelectedValue);
            DateTime fecha = Convert.ToDateTime(this.Calendario.SelectedDate);
            int hora = Convert.ToInt32(this.txtHora.Text.Trim());
            int minutos = Convert.ToInt32(this.txtMinutos.Text.Trim());
            double consumo = Convert.ToDouble(this.txtConsumo.Text.Trim());
            if (consumo>600 || consumo<0 && hora<0 || hora>24 && minutos<0 || minutos>60)
            {
                this.errorMsg2.Text = "Revise los datos ingresados!";
            }
            else
            {
                Lectura l = new Lectura()
                {
                    Id = id,
                    FechaLectura = fecha,
                    Hora = hora,
                    Minutos = minutos,
                    Consumo = consumo
                };
                lecturasDAL.AgregarLecturas(l);
                this.successMsg2.Text = "Lectura ingresada correctamente";
                Response.Redirect("VerLecturas.aspx");
            }
        }
    }
}