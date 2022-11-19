using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroPessoa.Interfaces;

namespace CadastroPessoa.Classes
{
    public abstract class Pessoa : iPessoa
    {
        public abstract Boolean ?PessoaFisica{get;set;}
        public abstract string ?nome {get;set;}
        public abstract string ?enderece{get;set;}
        public abstract long ?renda {get;set;}
        public abstract void CalcularImposto(long renda);
    }
}