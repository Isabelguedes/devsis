using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposPrimitivos
{
    class Program
    {
        enum Dias { domingo=100, segunda, terca, quarta, quinta, sexta, sabado };//Enum é uma estrutura de tipo de dados numerico, e não pode ficar dentro do metodo

        static void Main(string[] args)
        {
            //variaveis tipadas
            int numero = 3;
            float numero2 = 2f;
            //Cast como fortalecimento de tipo e conversão explicita
            int resultado = numero + (int) numero2;
            //String é um tipo de dado válido
            string texto = "Olá mundo";

            //bool é representado por true e false
            bool certidaoDeVivo = true;

            //Console.WriteLine(numero);
            //Console.WriteLine(texto);
            //Console.WriteLine(resultado);
            // Console.WriteLine(texto+" Você esta vivo? {0}", certidaoDeVivo);

            Dias dia = Dias.quinta;
            //Console.WriteLine("A referencia numerica do dia : " + (int)dia);

            //vetor Unidimensional
            int[] num = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arr = new int[10];

            //Console.WriteLine(num[5]);

            //Matriz
            int[,] mat = new int[5, 5];
            mat[0, 1] = 1;
            mat[0, 2] = 2;

            //Console.WriteLine("Valor da matriz na posição [0,1] :"+ mat[0, 1]);

            //Lista
            List<string> frutas = new List<String>();
            frutas.Add("pera");
            frutas.Add("maça");
            frutas.Add("Kiwi");

            frutas.Remove("pera");

            List<int> sorteio = new List<int>();
            sorteio.Add(1);

            Console.WriteLine(frutas[2]);

            Console.ReadLine();

            //comentario em Cshar é escrito com //{tambem} 
        }
    }
}
