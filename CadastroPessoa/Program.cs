// See https://aka.ms/new-console-template for more informationaccess object instance from another class c#
using CadastroPessoa.Classes;
using CadastroPessoa.Interfaces;

namespace Program
{
    public class Program
    {   
        public static PessoaFisicaJuridica? SpawnActor_1{get;set;}
        public static NewInstance? NovaInstancia_0{get;set;}
        public static long ?Rendimento{get;set;}
        

        public static void Main(string[] args)
        {
    
            NovaInstancia_0 = new NewInstance();
            NovaInstancia_0.initialEvent();
        }
    }


}
