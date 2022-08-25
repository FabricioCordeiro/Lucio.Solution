using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucio.Logic.Models
{
    public class Intervalo
    {
        public (double valor1, double valor2) Dados { get; set; }
        public double Frequencia { get; set; }
    }
}
