using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniProjeto.Data
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }
}
