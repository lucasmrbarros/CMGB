using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using CMGB.Classes;
using System.Security.Cryptography.X509Certificates;

namespace CMGB.Classes
{
    public class VeiculoMotorizado : Base
    {
        protected string ? Placa;


        protected bool MotorLigado;
        protected bool Emplacado;

        public VeiculoMotorizado()
        {
            Emplacado = false;
            MotorLigado = false;
        }
        public void LigarMotor()
        {
            MotorLigado = true;
            Console.WriteLine("O veículo tipo " + this.Tipo + " " + this.Fabricante + " "+ "" +this.Modelo + " esta com o motor ligado");
        }
        public void Emplacar()
        {
            if (Emplacado == true)
            {
                Console.WriteLine("O veículo tipo " + this.Tipo + " " + this.Fabricante + " " + this.Modelo + " já foi emplacado como: " + this.Placa);
            }
            else
            {
                Emplacado = true;
                Console.WriteLine("Insira a Placa:");
                Placa = Console.ReadLine();
                Console.WriteLine("O veículo tipo " + this.Tipo + " " + this.Fabricante + " " + this.Modelo + " Foi emplacado como " + this.Placa);
            }
        }
        public override void Acelerar()
        {
            if (MotorLigado == true)
            {
                Console.WriteLine("O veículo tipo " + this.Tipo + " " + this.Fabricante + " " + this.Modelo + " andou");
            }
            else
            {
                Console.WriteLine("O veículo tipo " + this.Tipo + " " + this.Fabricante + " " + this.Modelo + " não andou pois não esta com o motor ligado");
            }
        }
    }
}