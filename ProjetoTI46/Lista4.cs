using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI46
{
    internal class Lista4
    {
        public void menu04()
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



        public void exercicio2()
        {
            decimal idade;

            Console.WriteLine("Digite uma idade ");
            idade = decimal.Parse(Console.ReadLine());

            if (idade>=0 && idade <= 12)
            {
                Console.WriteLine("E uma crianca " );

            }
            else if (idade >= 13 && idade <= 17)
            {
                Console.WriteLine("E um adolescente " );
            }
            else if (idade >= 18 && idade <= 64)
            {
                Console.WriteLine("E um adulto " );
            }
            else if (idade >= 65)
            {
                Console.WriteLine("E idoso " );
            }
            else

            {
                Console.WriteLine("Idade invalida");


            }
        
        }


        public void exercicio3()
        {
            double nota;

            Console.WriteLine("Digite uma nota"); 
            nota = double.Parse(Console.ReadLine());

            if (nota >= 6)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else if (nota >=4)
            {
                Console.WriteLine("Aluno de Recuperacao");

            }

            else 
            {
                Console.WriteLine("Aluno Reprovado");
            }
           

        }



        public void exercicio4()
        {
            double peso, altura, imc;

            Console.WriteLine("Qual e o seu peso?");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual e sua altura");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso.");
            }
            else if ((imc >= 18.5 && imc < 25))
            {
                Console.WriteLine("Você está no peso normal.");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Você está com sobrepeso");


            }
            else
            {
                Console.WriteLine("Você está com obesidade.");
            }
        }






        public void exercicio5()
        
     
        {
            decimal num1, num2;

            
            Console.WriteLine("Escreva primeiro numero: ");
            num1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Escreva segundo numero: ");
            num2 = decimal.Parse(Console.ReadLine());

            if(num1 >num2)
            {
                Console.WriteLine("O primeiro numero");

            }
            else if(num2 > num1) 
            {
                Console.WriteLine("Segundo numero é menor ");

            }

        else
         {
                Console.WriteLine("Os numeros são iguais ");
         }
        
        
        
        
        }



           





    public void exercicio6()


        { 
            decimal idade;
          Console.WriteLine("Escreva a idade: ");
          idade= decimal.Parse(Console.ReadLine());
        
            if (idade>=18 && idade<=70)
            {
                Console.WriteLine("É obrigado a votar ");

            }

            else if ((idade >= 16 &&  idade<=17)  || idade > 70)
            {
                Console.WriteLine("Voto Facultativo ");
            }
            else
            {
                Console.WriteLine("Nao pode votar ");
            }
       

          
       }



        public void exercicio7()
        {
            double valor, desconto=0;
            Console.WriteLine("Digite um valor em dinheiro ");
            valor = double.Parse(Console.ReadLine());

       
            if (valor>100)

            {
                   desconto = valor*0.1;
                valor-= desconto;
            
            }

            Console.WriteLine("Valor da compra "+valor);


        }




        public void exercicio8()
        {
            decimal temp;
            Console.WriteLine("Digite a temperatura");
            temp = decimal.Parse(Console.ReadLine());

            if (temp < 15)
            {
                Console.WriteLine("Esta Frio ");
            }
            else if (temp >= 15 && temp <= 25)
            {
                Console.WriteLine("Esta agradavel ");
            }
            else
            {
                Console.WriteLine("Esta Quente ");
            }
        }    
    


        public void exercicio9()
        {
            decimal n1, n2, n3,soma;

            Console.WriteLine("Insira o primeiro numero");
            n1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero");
            n2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro numero");
            n3 = decimal.Parse(Console.ReadLine());

            soma = n1 + n2 + n3/3;

            if (soma>7)
            {
                Console.WriteLine("Aprovado ");
            }
            else
            {

                Console.WriteLine("Reprovado");
                    
            }

        }


        public void exercicio10()
        {
            decimal ano;
            Console.WriteLine("Digite um ano ");
            ano = decimal.Parse(Console.ReadLine());

            bool anobissexto = (ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0;
       
               if(anobissexto) 
            {
                Console.WriteLine(ano+"Ano e bissexto");
            }
            else 
            {
                Console.WriteLine(ano+"Nao e bissexto ");
            }
        
        
        }


    
    
    
    }
}