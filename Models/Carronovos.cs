using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;

namespace BH_Automoveis.Models
{
    public class Carronovos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int AnoFabr { get; set; }
        public double Valor { get; set; }
    }
}
