using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorLibrary.DTO
{
    public class Medidor
    {
        private int id;
        private string tipo;

        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public static List<Medidor> medidores = new List<Medidor>();
        public List<Medidor> ObtenerMedidores()
        {
            return medidores;
        }

        public void AgregarMedidor(Medidor m)
        {
            medidores.Add(m);
        }
    }
}
