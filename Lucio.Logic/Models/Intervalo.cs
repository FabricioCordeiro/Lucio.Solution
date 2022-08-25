using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucio.Logic.Models
{
    public class Intervalo
    {
        public (double valor1, double valor2) LenghtIntervalo { get; set; }
        public int Fi1 { get; set; } //fi = Frequência absoluta simples
        public int Fi2 { get; set; } //Fi = Frequência absoluta acumulada
        public int Fr1 { get; set; } //fr
        public int Fr2 { get; set; } //Fr
    }
}
