using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI46
{
    internal class Lista3
    {

        public void menu03()
        {




            string op;

            do
            {

                Console.WriteLine("Exercicio 1");
                Console.WriteLine("Exercicio 2");
                Console.WriteLine("Exercicio 3");
                Console.WriteLine("Exercicio 4");
                Console.WriteLine("Exercicio 5");
                Console.WriteLine("Exercicio 6");

                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)


                {

                    case 1:
                        exercicio1();
                        break;


                    case 2:
                        exercicio2();
                        break;


                    case 3:
                        exercicio3();
                        break;
                    case 4:
                        exercicio4();
                        break;
                    case 5:
                        exercicio5();
                        break;
                    case 6:
                        exercicio6();
                        break;

                    default:
                        Console.WriteLine("Operação inválida.");

                        break;
                }

                Console.WriteLine("Deseja continuar \n");
                op = Console.ReadLine().ToLower();

            } while (op == "s");
        }




        public void exercicio1()

        {
            int a, b, c, soma;

            Console.WriteLine("Digite o numero 1: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o numero 2 ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o numero 3 ");
            c = Convert.ToInt32(Console.ReadLine());

            soma = a + b + c;

            Console.WriteLine("Resultado é :" + soma);



        }


        public void exercicio2()
        {
            double nota1, nota2, nota3, nota4, media;
            Console.WriteLine("Escreva a nota 1 ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva a nota 2 ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva a nota 3 ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva a nota 4 ");
            nota4 = Convert.ToDouble(Console.ReadLine());


            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("O Resultao da media é: " + media);


        }



        public void exercicio3()
        {
            String nome = "";
            while (nome != "Joao")

            {
                Console.WriteLine("Digite um nome: ");
                nome = Console.ReadLine();

            } 

            Console.WriteLine("Quando o nome for Joao o codigo finaliza");

        }



        public void exercicio4()

        {
         
            int inicio = 35;
            int fim = 98111;
            int contadorPares = 0;

           
            for (int num = inicio; num <= fim; num++)
            {
                if (num % 2 == 0) 
                {
                    contadorPares++;
                }
            }
            Console.WriteLine($"A quantidade de números pares entre {inicio} e {fim} é: {contadorPares}");
        }





        public void exercicio5()
        {

            decimal somaImpar = 0;

            for (int num = 1; num <= 5000; num++)
            {
                if (num != 0)
                {
                    somaImpar += num;
                }
            }
            Console.WriteLine("Soma dos Impares de 1 a 5000 é: " + somaImpar);
        }



        public void exercicio6()

        {
            decimal num = 0;
            Console.WriteLine("Calcule a tabuada do:");
            num = Convert.ToDecimal(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\n" + num + "X" + i + "=" + num);
            }

        }   
    
   
    }
}
    
