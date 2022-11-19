using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroPessoa.Interfaces;

namespace CadastroPessoa.Classes
{
    public abstract class ProgramInstance : Instance
    {
        public abstract void initialEvent();
    }
}