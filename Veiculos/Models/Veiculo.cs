using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veiculos.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string AnoFabricacao { get; set; }
        public string AnoModelo { get; set; }
    }
}