using System;
using System.Collections.Generic;

namespace atv3
{
    class Program
    {

        static List<string> Participantes = new List<string>();
        static void Main(string[] args)
        {
            
            
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
                            CadastrarParticipante(name);
                            break;
                        default:
                            Console.WriteLine("Resposta invalida, digite uma resposta válida");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Pode entrar");
                    CadastrarParticipante(name);
                    
                }

                Console.WriteLine("Deseja cadastrar mais alguma pessoa? sim/não");
                Resposta = Console.ReadLine().ToLower();

            } while (Resposta== "sim");

            Console.WriteLine("Pessoas que participarão");

            
            ListarParticipantes();

             Console.WriteLine("Deseja repetir a lista? sim/não");
             string listaRepetir = Console.ReadLine();

            
             
             
            switch (listaRepetir)
            {
                case"sim":
                
                Console.WriteLine("Pessoas que participarão");
                ListarParticipantes();

                break; 
                case"não":

                Console.WriteLine("Cadastro concluido");

                break;

                 
                default:

                   Console.WriteLine("Resposta invalida");
                   
                break;
             } 
             
            

        
        }


        static void ListarParticipantes(){

            foreach (string cadanome in Participantes)
            
            {
                Console.WriteLine(cadanome);

            }
        }

        static void CadastrarParticipante(string name){

                    Participantes.Add(name);
        }
    }
}
