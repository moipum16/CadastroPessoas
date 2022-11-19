using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroPessoa.Interfaces;
using CadastroPessoa.Classes;

namespace CadastroPessoa.Classes
{
    public class NewInstance : ProgramInstance, Instance
    {
        public long ?Rendimento{get;set;}
        public long NumeroDeUsuarios{get;set;}
        public List<string> Clients = new List<string>();
        public override void initialEvent()
        {
            

            long RequerirRendimento()
            {
                try
                {   
                    Program.Program.SpawnActor_1 = new PessoaFisicaJuridica();
                    NumeroDeUsuarios=0;

                    Console.WriteLine("Lista de clientes; ");
                    Console.WriteLine(" ");
                    Console.WriteLine("*********************************************************************");
                    Console.WriteLine(" ");

                    for(;NumeroDeUsuarios<Program.Program.SpawnActor_1.Clients.Count;NumeroDeUsuarios++)
                    {
                        Console.WriteLine("Usuário "+Program.Program.SpawnActor_1.Clients.Count+": "+Program.Program.SpawnActor_1.Clients[Program.Program.SpawnActor_1.Clients.Count-1]);
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("*********************************************************************");
                    Console.WriteLine(" ");
                    Console.WriteLine("Qual o Rendimento do Cliente?");

                    Rendimento=Convert.ToInt64(Console.ReadLine());
                    Program.Program.SpawnActor_1.CalcularImposto((long)Rendimento);
                    Program.Program.SpawnActor_1.rendaConcluido=true;

                    Clients= Program.Program.SpawnActor_1.Clients;

                    Recursao(Program.Program.SpawnActor_1);

                    return (long)Rendimento;
                    

                }catch(Exception)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Digite um número inteiro válido!");
                    Rendimento=0;
                    RequerirRendimento();
                    return (long)Rendimento;
                }

            }

            void Recursao(PessoaFisicaJuridica spawnActor_1)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Cliente "+(Program.Program.SpawnActor_1.Clients.Count-1)+" adicionado! "+Program.Program.SpawnActor_1.Clients[Program.Program.SpawnActor_1.Clients.Count-1]);
                Console.WriteLine(" ");
                RequerirRendimento();
            }

            RequerirRendimento();

        }
    }
}
