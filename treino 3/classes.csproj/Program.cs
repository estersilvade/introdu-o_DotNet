// See https://aka.ms/new-console-template for more information
using System;
using Classes.Herança;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
           Ponto p1 = new Ponto(10, 20);
           
           Ponto p2 = new Ponto3D (10, 20, 30);
        }
    }
}
