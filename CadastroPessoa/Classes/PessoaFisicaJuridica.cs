using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroPessoa.Interfaces;
using CadastroPessoa.Classes;

namespace CadastroPessoa.Classes
{
    public class PessoaFisicaJuridica : Pessoa, iPessoa
    {
        public override bool? PessoaFisica { get; set; }
        public override string? nome{get;set;}
        public override string? enderece { get ; set ; }
        public override long? renda{get;set;}

        public static NewInstance? NovaInstancia_0;
        public static NewInstance? NovaInstancia_1{get;set;}
        public bool? PessoaFisicaConcluido{get;set;}
        public bool? nomeConcluido{get;set;}
        public bool? endereceConcluido{get;set;}
        public bool? rendaConcluido{get;set;}
        public List<string> Clients = new List<string>();

        public override void CalcularImposto(long renda)
        {

            String eNome()
            {
                try
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Qual o nome do Cliente?");
                    nome=Console.ReadLine();
                    if (nome==null)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("O campo não deve estar vazio.");
                        nome="";
                        nomeConcluido=false;
                        eNome();
                        return nome;

                    }else
                    {
                        nomeConcluido=true;
                        return nome;

                    }

                }catch
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Caracteres inválidos!");
                    nome="";
                    nomeConcluido=false;
                    eNome();
                    return nome;
                }
            }

            Boolean eCPF()
            {
                try
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Cliente é Pessoa física? Digite True ou False.");

                    PessoaFisica=Convert.ToBoolean(Console.ReadLine());
                    PessoaFisicaConcluido=true;

                    return (bool)PessoaFisica;


                }catch(Exception)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Digite um valor válido! true ou false.");
                    PessoaFisica=false;
                    PessoaFisicaConcluido=false;
                    eCPF();
                    return (bool)PessoaFisica;
                }
            }

            String eEnderece()
            {
                try
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Qual o endereço do Cliente?");
                    enderece=Console.ReadLine();
                    if (enderece==null)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("O campo não deve estar vazio.");
                        enderece="";
                        endereceConcluido=false;
                        eEnderece();
                        return enderece;

                    }else
                    {
                        Clients.Add("Nome: "+nome+", Pessoa física?: "+PessoaFisica+", Endereço: "+enderece+ ", Renda: "+renda+".");
                        endereceConcluido=true;
                        return enderece;

                    }

                }catch
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Caracteres inválidos!");
                    enderece="";
                    endereceConcluido=false;
                    eEnderece();
                    return enderece;
                }
            }

            eNome();
            eCPF();
            eEnderece();

        }

    }
}