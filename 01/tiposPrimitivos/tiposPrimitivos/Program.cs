using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposPrimitivos
{
    class Program
    {
        enum Dias { domingo, segunda, terca, quarta, quinta, sexta, sabado };//Enum é uma estrutura de tipo de dados numerico, e não pode ficar dentro do metodo

        static void Main(string[] args)
        {
            //variaveis tipadas
            int numero = 3;
            float numero2 = 2f;
            int resultado = numero + (int) numero2;
            string texto = "Olá mundo";

            //bool é representado por true e false
            bool certidaoDeVivo = true;

            Dias dia = Dias.quinta;

            //Console.WriteLine(numero);
            //Console.WriteLine(texto);
           // Console.WriteLine(resultado);
           // Console.WriteLine(texto+" Você esta vivo? {0}", certidaoDeVivo);
           
           

            Console.ReadLine();

            //comentario em Cshar é escrito com //{tambem} 
        }
    }
}
