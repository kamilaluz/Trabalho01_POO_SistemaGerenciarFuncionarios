﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarFuncionarios.Classes
{
    internal interface IFuncionarios
    {
        double ReajustarSalario();
        double CalcularPPR();
        void ExibirInformacoes();
    }
}
