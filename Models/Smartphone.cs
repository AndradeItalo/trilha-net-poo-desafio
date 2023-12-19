using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Imei { get; set; } 
        public string Modelo { get; set; }
        public int Memoria { get; set; } 

        public Smartphone(string numero, string modelo, string imei, int memoria) 
        {
            Numero = numero;
            Imei = imei;
            Modelo = modelo;
            Memoria = memoria; // Passando os parâmetros do construtor para as propriedades
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
