using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMGB.Classes
{
    public class Base
    {
        public int Id;

        public string Tipo;
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public string Cor { get; set; }
        

        virtual public void Acelerar()
        {
            Console.WriteLine("O veículo tipo " + this.Tipo + " " + this.Fabricante + " " + this.Modelo + " " + this.Tipo + " andou");
        }
        public void Frear()
        {
            Console.WriteLine("O veículo tipo " + this.Tipo + " " + this.Fabricante + " " + this.Modelo + " freou");
        }
    }
}
