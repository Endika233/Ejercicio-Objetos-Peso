using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Objetos_Peso
{
    class Peso
    {
        private double peso,kg;
        private string medida;
        public Peso(double peso, string medida)
        {
            this.peso = peso;
            this.medida = medida.ToUpper();
            ToKilo();
        }
        public void ToKilo()
        {
            if (medida == "K")
            {
                kg=this.peso;
            }
            if (medida == "LB")
            {
                kg = peso * 0.453;
            }
            if (medida == "LI")
            {
                kg = peso * 14590;
            }
            if (medida == "OZ")
            {
                kg = peso * 0.02835;
            }
            if (medida== "P")
            {
                kg = peso * 0.00155;
            }
            if (medida == "G")
            {
                kg = peso * 1000;
            }
            if (medida == "Q")
            {
                kg = peso * 43.3;
            }
        }
        public void GetLibras()
        {
            Console.WriteLine("El peso introducido es " +kg/0.453+" libras");
        }
        public void GetLingotes()
        {
            Console.WriteLine("El peso introducido es " + kg / 14.59+" lingotes");
        }
        public void GetPeso(string medida)
        {
            switch(medida.ToUpper())
            {
                case "LB":
                    GetLibras();                    
                    break;
                case "LI":
                    GetLingotes();
                    break;
                case "OZ":
                    Console.WriteLine("El peso introducido  es " + kg / 0.02835 + " onzas");
                    break;
                case "P":
                    Console.WriteLine("El peso introducido es " + kg / 0.00155 + " peniques");
                    break;
                case "K":
                    Console.WriteLine("El peso introducido es " + kg + " kilogramos");
                    break;
                case "G":
                    Console.WriteLine("El peso introducido es " + kg * 1000 + " gramos");
                    break;
                case "Q":
                    Console.WriteLine("El peso introducido en lingotes es " + kg / 43.3 + " quintales");
                    break;
            }     
        }
    }
}
//Deberá tener un atributo donde se almacene el peso de un objeto en kilogramos.
//En el constructor se le pasará el peso y la medida en la que se ha tomado (‘Lb’ para libras, ‘Li’ para lingotes,‘Oz’ para onzas, ‘P’ para peniques, ‘K’ para kilos, ‘G’ para gramos y ‘Q’ para quintales).
//Deberá de tener los siguientes métodos:
//GetLibras.Devuelve el peso en libras.
//GetLingotes.Devuelve el peso en lingotes.
//GetPeso.Devuelve el peso en la medida que se pase como parámetro(‘Lb’ para libras, ‘Li’ para lingotes,‘Oz’ para onzas, ‘P’ para peniques, ‘K’ para kilos, ‘G’ para gramos y ‘Q’ para quintales).
 
//Para la realización del ejercicio toma como referencia los siguientes datos:
//1 Libra = 16 onzas = 453 gramos.
//1 Lingote = 32,17 libras = 14,59 kg.
//1 Onza = 0,0625 libras = 28,35 gramos.
//1 Penique = 0,05 onzas = 1,55 gramos.
//1 Quintal = 100 libras = 43,3 kg.
//Crea además un método main para testear y verificar los métodos de esta clase.

