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
        public List<double> Rol { get; set; }
        public double AmplitudeTotal { get; set; }
        public double AmplitudeDoIntervalo { get; set; }

        public List<Intervalo> Table { get; set; }

        public Calc(List<double> dados, int intervalo)
        {
            Dados = dados;
            Rol = GetRol();
            AmplitudeTotal = GetAmplitudeTotal();
            AmplitudeDoIntervalo = GetAmplitudeDoIntervalo(intervalo);

            Table = new();
        }

        public List<Intervalo> GetTable() => 
            Table;

        private List<double> GetRol() =>
            Dados.OrderBy(x => x).ToList();

        private double GetAmplitudeTotal()
            => Dados.Max() - Dados.Min();

        private double GetAmplitudeDoIntervalo(int intervalo)
            => AmplitudeTotal / intervalo;
        
    }
}
