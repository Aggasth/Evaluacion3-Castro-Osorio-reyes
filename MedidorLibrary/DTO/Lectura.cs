using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorLibrary.DTO
{
    public class Lectura
    {
        private int id;
        private DateTime fechaLectura;
        private int hora;
        private int minutos;
        private double consumo;

        public int Id { get => id; set => id = value; }
        public DateTime FechaLectura { get => fechaLectura; set => fechaLectura = value; }
        public int Hora { get => hora; set => hora = value; }
        public int Minutos { get => minutos; set => minutos = value; }
        public double Consumo { get => consumo; set => consumo = value; }
    }
}
