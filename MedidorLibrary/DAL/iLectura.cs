using MedidorLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorLibrary.DAL
{
    public interface iLectura
    {
        void AgregarLecturas(Lectura l);
        List<Lectura> ObtenerLecturas();
        List<Lectura> FiltrarLectura(int id);
    }
}
