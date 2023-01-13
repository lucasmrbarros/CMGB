using CMGB.Classes;
using System;

internal class Program
{
    private static void Main(string[] args)
    {

        Moto Honda = new Moto(1, "Honda", "CBR", "2009", "Azul");
        Honda.Emplacar();
        Honda.LigarMotor();
        Honda.Acelerar();
        Honda.Frear();

        Console.WriteLine("_____________________________________________________________________");

        Moto Ducati = new Moto(2, "Ducati", "Monster", "2016", "preta");
        Ducati.Emplacar();
        Ducati.LigarMotor();
        Ducati.Acelerar();
        Ducati.Frear();

        Console.WriteLine("_____________________________________________________________________");

        Moto Yamaha = new Moto(3, "Yamaha", "MT-03", "2018", "Branca");
        Yamaha.Emplacar();
        Yamaha.LigarMotor();
        Yamaha.Acelerar();
        Yamaha.Frear();

        Console.WriteLine("_____________________________________________________________________");

        Carro BMW = new Carro(4, "BMW", "M3", "2021", "Preto");
        BMW.Emplacar();
        BMW.Acelerar();
        BMW.Frear();
        BMW.LigarMotor();

        Console.WriteLine("_____________________________________________________________________");

        Carro Ferrari = new Carro(5, "Ferrari", "Scuderia", "2009", "Vermelho");
        Ferrari.Emplacar();
        Ferrari.LigarMotor();
        Ferrari.Acelerar();
        Ferrari.Frear();

        Console.WriteLine("_____________________________________________________________________");

        Carro Ford = new Carro(6, "Ford", "Fiesta", "2009", "Prata");
        Ford.Emplacar();
        Ford.LigarMotor();
        Ford.Acelerar();
        Ford.Frear();

        Console.WriteLine("_____________________________________________________________________");

        Carro Lamborghini = new Carro(7, "Lamborghini", "Huracán", "2022", "Amarelo");
        Lamborghini.Emplacar();
        Lamborghini.LigarMotor();
        Lamborghini.Acelerar();
        Lamborghini.Frear();

        Console.WriteLine("_____________________________________________________________________");

        Bicicleta Oggi = new Bicicleta(8, "Oggi", "Velloce Disc", "2023", "Vermelho");
        Oggi.Acelerar();
        Oggi.Frear();

        Console.WriteLine("_____________________________________________________________________");

        Bicicleta Caloi = new Bicicleta(9, "Caloi", "Sk-21", "2010", "Preto");
        Caloi.Acelerar();
        Caloi.Frear();

        Console.WriteLine("_____________________________________________________________________");

       Bicicleta Sense = new Bicicleta(10, "Sense", "Criterium Factory", "2022", "Branco");
    }
}