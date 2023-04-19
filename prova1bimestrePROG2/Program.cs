using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova1bimestrePROG2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int exercicio;
            Console.WriteLine("qual exercicio voce deseja realizar?");
            Console.WriteLine("EXERCICIO 1");
            Console.WriteLine("EXERCICIO 2");
            Console.WriteLine("EXERCICIO 3");
            Console.WriteLine("EXERCICIO 4");
            Console.WriteLine("EXERCICIO 5");
            Console.WriteLine("EXERCICIO 6");
            Console.WriteLine("EXERCICIO 7");
             exercicio = int.Parse(Console.ReadLine());

            switch (exercicio)
            {
                case 1:

                    double nm,nmABS;
                    Console.WriteLine("escreve um numero");
                    nm = double.Parse(Console.ReadLine());

                    if (nm < 0)
                    {
                        nmABS = nm * -1; 
                        Console.WriteLine("o numero perfeito é " + nmABS);

                    }
                    else if (nm > 0)
                    {
                        nmABS = nm;
                       Console.WriteLine("o numero perfeito é " + nmABS);
                    }
                    Console.ReadKey();

                    break;


                case 2:
                    int num;
                    Console.WriteLine("informe um numero para realizar o programa");
                        num = int.Parse(Console.ReadLine());

                    if (num % 3 == 0 && num % 5 == 0)
                    {
                        Console.WriteLine("este numero é divisivel por 3 e 5");
                    }

                     else if (num % 4 == 0 && num % 7 == 0)
                    {
                        Console.WriteLine("este numero é divisivel por 4 e 7");
                    }
                     else if (num % 3 == 0 )
                    {
                        Console.WriteLine("este numero é divisivel por 3");
                    }
                    else if (num % 5 == 0)
                    {
                        Console.WriteLine("este numero é divisivel por 5");
                    }
                    else if (num % 4 == 0)
                    {
                        Console.WriteLine("este numero é divisivel por 4");
                    }
                    else if (num % 7 == 0)
                    {
                        Console.WriteLine("este numero é divisivel por 7");
                    }
                    else
                    {
                        Console.WriteLine("não há possibilidade de divisão");
                    }
                    Console.ReadKey();
                    break;


                case 3:

                    int val1, val2, val3, temp;
                    Console.WriteLine("fale um numero");
                    val1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("fale um numero diferente do anterior");
                    val2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("fale um numero diferente dos anteriores");
                    val3 = int.Parse(Console.ReadLine());

                    if (val1 > val2)
                    {
                        temp = val1;
                        val1 = val2;
                        val2 = temp;
                    }

                   else if (val2 > val3)
                    {
                        temp = val2;
                        val2 = val3;
                        val3 = temp;
                    }

                    else if (val1 > val2)
                    {
                        temp = val1;
                        val1 = val2;
                        val2 = temp;
                    }

                    Console.WriteLine($"Os valores em ordem crescente são: este é o menor valor {val1}, e este o maior valor {val3}");

                    Console.ReadKey();






                    break;






                case 4:

                    int dia;
                    Console.WriteLine("digite um numero de 1 a 7 para saber o dia e as materias ");
                    dia = int.Parse(Console.ReadLine());

                    switch (dia)
                    {
                        case 1:
                            Console.WriteLine("domingo= jogar um futebol com os amigos");

                            break;
                        case 2:
                            Console.WriteLine("segunda = filosofia, portugues e matematica");
                            break;

                        case 3:
                            Console.WriteLine("terça = quimica,historia e IMI");
                            break;

                        case 4:
                            Console.WriteLine("quarta = biologia, portugues e programação");
                          break;

                                case 5:
                            Console.WriteLine("quinta = fisica, redes e sociologia");
                            break;

                        case 6:
                            Console.WriteLine("sexta = geografia, matematica e banco de dados");
                            break;
                        case 7:
                            Console.WriteLine("sabado = sair para festa");
                            break;

                        default:
                            Console.WriteLine("este numero não corresponde a nenhum dia");
                            break;
                    }
                    Console.ReadKey();

                    break;


                case 5:
                       int numero;
                    int maiorValor = 0;//int.MinValue;
                   int menorValor = 0;//int.MaxValue;
                   // string maior = "", menor = "";

                    Console.WriteLine("qual numero você deseja informar para o programa(que seja um numero interio)");
                    numero = int.Parse(Console.ReadLine());

                    for (; numero <= 0;)
                    {

                        if (numero > maiorValor)
                        {
                            maiorValor = numero;

                        }
                        else if (numero > menorValor)
                        {
                            menorValor = numero;
                           
                        }
                     Console.WriteLine("o maior valor é:" + maiorValor);
                       Console.WriteLine("o menor numero é:" + menorValor);
                        }
                    Console.ReadKey();
                    break;


                case 6:

                    int nmPER, soma = 0 ;

                    Console.WriteLine("digite um numero para sabermos se é perfeito");
                    nmPER = int.Parse(Console.ReadLine());

                    for (int i = 1; nmPER > i; i++)
                    {

                        if (nmPER % i == 0)
                        {
                            soma += i;

                        }
                    }






                    if (soma == nmPER)
                        {
                            Console.WriteLine(nmPER + " é um numero perfeito");
                        }
                       else
                        {
                            Console.WriteLine("não é um numero perfeito");
                        }



                    

                    Console.ReadKey();

                    break;



                case 7:

                    int nume, media = 0;
                    Console.WriteLine("informe um numero");
                    nume = int.Parse(Console.ReadLine());

                    for (int n = 1; n < nume; n++)
                    {
                        if (nume % 2 == 0)
                        {
                            media += nume;
                            Console.WriteLine("a soma dos numeros é " + media);

                        }
                        else 
                           {
                            Console.WriteLine("este numero é impar");
                        }
                    }
                    Console.ReadKey();
                    break;






                default:
                    Console.WriteLine("este numero não representa nenhum problema ");
                    break;
            }

        }
    }
}
