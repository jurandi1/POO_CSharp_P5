using System;
using System.Drawing;

namespace POO_CSharp_P5
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            //Tipos referência vs.tipos valor
            //CLASSE
            //Vantagem: usufrui de todos recursos OO
            //Variáveis são ponteiros
            //Objetos precisam ser instanciadas usando new, ou
            //apontar para um objeto já existente.
            //Aceita valor null
            //Suporte a herança
            //Y = X;
            //"Y passa a apontar para onde X aponta"
            //Objetos instanciados no heap
            //Objetos não utilizados são desalocados em um
            //momento próximo pelo garbage collector
            //STRUCT
            //Vantagem: é mais simples e mais performático
            //Variáveis são caixas
            //Não é preciso instanciar usando new, mas é possível
            //Não aceita valor null
            //Não tem suporte a herança(mas pode implementar
            //interfaces)
            //Y = X;
            //"Y recebe uma cópia de X"
            //Objetos instanciados no stack
            //"Objetos" são desalocados imediatamente quando
            //seu escopo de execução é finalizado

            //EXEMPLO: 
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
        }
    }
}