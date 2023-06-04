using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro
{
    class Entrada : Lancamento
    {
        protected Entrada(string descricao, double value, DateTime data) : base(descricao, value, data)
        {
        }
        public override double Value()
        {
            return this._value;
        }
    }
}
