using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI46
{
    internal class Lista2
    {
        public void menu02()
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
                Console.WriteLine("Exercicio 7");
                Console.WriteLine("Exercicio 8");
                Console.WriteLine("Exercicio 9");
                Console.WriteLine("Exercicio 10");
                Console.WriteLine("Exercicio 11");

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
                    case 7:
                        exercicio7();
                        break;
                    case 8:
                        exercicio8();
                        break;
                    case 9:
                        exercicio9();
                        break;
                    case 10:
                        exercicio10();
                        break;
                    case 11:
                        exercicio11();
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
            decimal numero;
            Console.WriteLine("Digite um numero");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 20)
            {
                Console.WriteLine("Ele é maior que 20");

            }
            else
            {
                Console.WriteLine("Ele nao e maior que 20");
            }

        }




        public void exercicio2()

        {
            decimal numero;
            Console.WriteLine("Digite um numero");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 20)
            {
                Console.WriteLine("Ele é maior que 10");

            }
            else
            {
                Console.WriteLine("Ele nao e maior que 10");
            }

        }


        public void exercicio3()

        {

            decimal a, b, c;
            Console.WriteLine("Digite um valor para A ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um valor para B");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor para C");
            c = Convert.ToInt32(Console.ReadLine());

            if (a + b < c)
            {
                Console.WriteLine($"A soma de A + B ({a + b}) é menor que C ({c}).");

            }
            else
            {
                Console.WriteLine("Nao e Menor ");

            }

        }


        public void exercicio4()
        {

            decimal n1, n2, soma;
            Console.WriteLine("Digite um numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro numero");
            n2 = Convert.ToInt32(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine("Resultado  \n " + soma);

            if (soma > 10)
            {
                Console.WriteLine("Resultado foi maior que 10");
            }
            else
            {
                Console.WriteLine("Nao Foi Maior que 10");
            }


        }



        public void exercicio5()
        {
            string nome, sexo, estadocivil, tempo;
            Console.WriteLine("Digite seu nome ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o sexo (M/F)");
            sexo = Console.ReadLine();
            Console.WriteLine("Qual estado civil ");
            estadocivil = Console.ReadLine();


            if (sexo == "F" && estadocivil == "Casada")
            {
                Console.WriteLine("Digite tempo de casada");
                tempo = Console.ReadLine();
                Console.WriteLine("Sou casada a " + tempo + " anos");

            }


        }




        public void exercicio6()

        {
            decimal numero;
            Console.WriteLine("Digite um numero:");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 1)
            {
                Console.WriteLine("Impar");

            }
            else

            {

                Console.WriteLine("Par");
            }



        }



        public void exercicio7()
        {
            decimal a, b, c, soma;
            Console.WriteLine("Numero A");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numero B");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                c = a + b;
            }
            else
            {
                c = a * b;
            }

            Console.WriteLine("Resulado " + c);
        }


        public void exercicio8()
        {
            int numero, resultado;
            Console.WriteLine("Coloque um numero");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0)
            {
                resultado = numero * 2;
            }
            else
            {
                resultado = numero * 3;
            }

            Console.WriteLine("O resultado é: " + resultado);
        }


        public void exercicio9()

        {
            double vl1, vl2, vl3;
            Console.WriteLine("Escreva o valor 1: ");
            vl1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva o valor 2: ");
            vl2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva o valor 3: ");
            vl3 = Convert.ToDouble(Console.ReadLine());

            double[] valores = { vl1, vl2, vl3 };


            Array.Sort(valores);
            Array.Reverse(valores);


            Console.WriteLine("Os valores em ordem decrescente são:");
            foreach (double valor in valores)
            {
                Console.WriteLine(valor);
            }
        }


        public void exercicio10()
        {
            int valor1, valor2, valor3;
            int menor, meio, maior;
            Console.WriteLine("Escreva o primeiro valor ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva o segundo valor ");
            valor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva o terceiro valor ");
            valor3 = Convert.ToInt32(Console.ReadLine());

            if ((valor1 < valor2) && (valor1 < valor3))
            {
                menor = valor1;
            
                            
            if (valor2 < valor3)
            
                meio = valor2;
                maior = valor3;
            }
            else

            {
                menor = valor3;


                if (valor1 < valor2)
                {

                    meio = valor1;
                    maior = valor2;
                }

                else
                {
                    meio = valor2;
                    maior = valor1;



                    Console.WriteLine("Os valor crescente sao : "+menor + meio + maior);
                }

            }


        }


            public void exercicio11()
 
            {
                int horaInicio, horafim, duracao, horasMaximas,
                    horasRestantes, horasExcedentes;
                horasMaximas = 24;
                Console.WriteLine("Digite a hora do inicio do jogo:");
                horaInicio = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a hora do fim do jogo");
                horafim = Convert.ToInt32(Console.ReadLine());

                if (horafim > horaInicio)
                {

                    duracao = horafim - horaInicio;
                }
                else if (horafim == horaInicio)
                {
                    duracao = horasMaximas;
                }

                else
                {
                    duracao = (horasMaximas - horaInicio) - horaInicio;

                }

                Console.WriteLine("Duração do Jogo: " + duracao + "horas");

                if (duracao > horasMaximas)
                {
                    horasExcedentes = duracao - horasMaximas;

                    Console.WriteLine("Você exedeu o tempo de jogo por: " + horasExcedentes + "Horas de jogo");
                }

                else
                {
                    horasRestantes = horasMaximas - duracao;
                    Console.WriteLine("Ainda restam " + horasRestantes + " horas de jogo.");
                }
            }








        }

    }



