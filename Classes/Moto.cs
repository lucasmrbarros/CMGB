using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMGB.Classes
{
    public class Moto : VeiculoMotorizado
    {
        public Moto(int id, string fabricante, string modelo, string ano, string cor)
        {
            this.Id = id;
            this.Tipo = "Motocicleta";
            this.Fabricante = fabricante;
            this.Modelo= modelo;
            this.Ano= ano;
            this.Cor= cor;
        }
    }
}
