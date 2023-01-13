using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMGB.Classes
{
    public class Carro : VeiculoMotorizado
    {
        public Carro (int id, string fabricante, string modelo, string ano, string cor)
        {
            this.Id = id;
            this.Tipo = "Carro";
            this.Fabricante = fabricante;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Cor = cor;
        }
    }
}
