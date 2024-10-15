using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI46
{
    internal class Lista1
    {

        public void menu01()
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
            Console.WriteLine("Ola Mundo");
        }


        public void exercicio2()

        {


            Console.WriteLine("Qual e o seu nome ?");
            string nome = Console.ReadLine();
            Console.WriteLine(" Ola é um prazer te conhecer " + nome);
        }


        public void exercicio3()
        {
         //solicita nome funcionario
         Console.WriteLine("Nome do funcionario?");
         string nome = Console.ReadLine();
         //solicita salario funcionario
         Console.WriteLine("Salario");
         decimal salario = decimal.Parse(Console.ReadLine());
         Console.WriteLine($"O funcionário {nome} tem um salário de {salario} em Junho");



        }

        public void exercicio4()
        {
         decimal num1, num2, soma;
         Console.WriteLine("Digite Primeiro Numero \n");
         num1 = decimal.Parse(Console.ReadLine());
         Console.WriteLine("Digite Segundo Numero \n");
         num2 = decimal.Parse(Console.ReadLine());

         soma = num1 + num2;
         Console.WriteLine("Resultado da soma é \n " + soma);

        }

        public void exercicio5()

        {
         double nota1,nota2,media;
         Console.WriteLine("Digite a primeira nota \n");
         nota1=double.Parse(Console.ReadLine());
         Console.WriteLine("Digite a segunda nota \n");
         nota2 = double.Parse(Console.ReadLine()); 
         media= (nota1 + nota2)/2;
         Console.WriteLine("Media final do aluno é: \n"+media);
            
        }




        public void exercicio6()
        {
         decimal numero, antecessor, sucessor;
         Console.WriteLine("Digite um numero \n");
         numero = decimal.Parse(Console.ReadLine());
         antecessor = numero - 1;
         sucessor = numero + 1;
         Console.WriteLine("Sucessor: " + sucessor);
         Console.WriteLine("Antecessor: " + antecessor);

        }

        public void exercicio7()
        
        {

         double num, dobro, terco;
         Console.WriteLine("Digite um numero real ");
         num=double.Parse(Console.ReadLine());
         dobro = num * 2;
         terco = num / 3;

         Console.WriteLine($"O dobro de {num} é {dobro}.");
         Console.WriteLine($"A terça parte de {num} é {terco}.");

        }

        



        public void exercicio8()
        {
            Console.WriteLine("Digite um quantidade em metros: \n ");

            double m=Convert.ToDouble(Console.ReadLine());

            double km = m / 1000;
            double cm = m *100;
            double mm = m * 1000;
            double dam = m /10;
            double dm = m *10;
            double hm = m /100;
             
            Console.WriteLine("Equivalem a KM : " + km);
            Console.WriteLine("Equivalem a CM: " + cm);
            Console.WriteLine("Equivalem a MM: " + mm);
            Console.WriteLine("Equivalem a DAM: " + dam);
            Console.WriteLine("Equivalem a DM: " + dm);
            Console.WriteLine("Equivalem a HM: " + hm);
        }


        public void exercicio9()
        {
         double dolar, real,valor = 3.45;
         Console.WriteLine("Mostre quantos reais a pessoa tem na carteira \n");
         real = double.Parse(Console.ReadLine());
         dolar = real /valor;
         Console.WriteLine("Escreva Dolar \n" + dolar);
        }





        public void exercicio10() 
        {

            Console.Write("Digite a largura da parede em metros: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura da parede em metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());

   
            double area = largura * altura;

      
            double litrosDeTinta = area / 2; 
     
            Console.WriteLine($"Área da parede: {area} m²");
            Console.WriteLine($"Quantidade de tinta necessária: {litrosDeTinta} litros");

        }





            

    }

}





