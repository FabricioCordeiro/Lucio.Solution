using Lucio.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucio.Logic.Actions
{
    public class Calc
    {
        public List<double> Dados { get; set; }
        public int Intervalo { get; set; }
        public List<double> Rol { get; set; }
        public double AmplitudeTotal { get; set; }
        public double AmplitudeDoIntervalo { get; set; }

        public List<Intervalo> Table { get; set; }
        public double Fi1Total { get; set; } //fi

        public Calc(List<double> dados, int intervalo)
        {
            Dados = dados;
            Intervalo = intervalo;

            Rol = GetRol();
            AmplitudeTotal = GetAmplitudeTotal();
            AmplitudeDoIntervalo = GetAmplitudeDoIntervalo();
            Table = GetTable();
        }

        private List<Intervalo> GetTable()
        {
            var table = new List<Intervalo>();
            double init = Dados.Min();
            double fi2 = 0;
            double fr2 = 0;

            for (double i = init; i < Dados.Max(); i = init)
            {
                double valor1 = init;
                double valor2 = init + AmplitudeDoIntervalo;
                double fi = 0;

                if (valor2 != Dados.Max())
                {
                    fi = Dados.Where(x => x >= init && x < valor2).Count();
                }
                else
                {
                    fi = Dados.Where(x => x >= init && x <= valor2).Count();
                }

                var intervalo = new Intervalo
                {
                    LenghtIntervalo = (valor1, valor2),
                    Fi1 = fi,
                    Fi2 = fi + fi2,
                };

                table.Add(intervalo);
                Fi1Total += fi;
                fi2 += fi;
                init = valor2;
            }

            foreach (var item in table)
            {
                item.Fr1 = item.Fi1 / Fi1Total * 100;
                fr2 += item.Fr1;
                item.Fr2 = fr2;
            }

            return table;
        }

        private List<double> GetRol() =>
            Dados.OrderBy(x => x).ToList();

        private double GetAmplitudeTotal()
            => Dados.Max() - Dados.Min();

        private double GetAmplitudeDoIntervalo()
            => AmplitudeTotal / Intervalo;

    }
}
