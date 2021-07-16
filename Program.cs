using System;
using System.Collections.Generic;

namespace atv3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Participantes = new List<string>();
            string Resposta;

            do
            {
                Console.WriteLine("Qual o seu nome?");
                string name = Console.ReadLine();

                Console.WriteLine("Qual sua idade?");
                int idade = int.Parse(Console.ReadLine());



                if (idade < 16)
                {
                    Console.WriteLine("Você estara acompanhado de um responsavel maior de idade? sim / não");
                    string pais = Console.ReadLine();
                    switch (pais)
                    {
                        case "não":
                            Console.WriteLine("SAI FORA");
                            break;
                        case "sim":
                            Console.WriteLine("Você pode participar");
                            Participantes.Add(name);
                            break;
                        default:
                            Console.WriteLine("Resposta invalida, digite uma resposta válida");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Pode entrar");
                    Participantes.Add(name);
                }

                Console.WriteLine("Deseja cadastrar mais alguma pessoa? sim/não");
                Resposta = Console.ReadLine().ToLower();

            } while (Resposta== "sim");


            Console.WriteLine("Pessoas que participarão");
            foreach (string cadanome in Participantes)
            {
                Console.WriteLine(cadanome);

            }


                          
        }
    }
}
