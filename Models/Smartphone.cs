using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular_POO.Models
{
    public abstract class Smartphone
    {
        public String Numero { get; set; }
        private String Modelo { get; set; }
        private String IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria){
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }  

         public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}