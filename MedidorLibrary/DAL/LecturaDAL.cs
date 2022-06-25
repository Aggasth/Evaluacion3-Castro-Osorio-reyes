using MedidorLibrary.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorLibrary.DAL
{
    public class LecturaDAL : iLectura
    {
        public static List<Lectura> lecturas = new List<Lectura>();

        public List<Lectura> ObtenerLecturas()
        {
            return lecturas;
        }
        public void AgregarLecturas(Lectura l)
        {
            lecturas.Add(l);
        }

        public List<Lectura> FiltrarLectura(int id)
        {
            List<Lectura> lista = new List<Lectura>();
            for (int i = 0; i < lecturas.Count; i++)
            {
                if (lecturas[i].Id.Equals(id))
                {
                    Lectura l = lecturas[i];
                    lista.Add(l);
                }
            }
            return lista;
        }
    }
}
