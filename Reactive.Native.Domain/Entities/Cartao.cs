using System;
using System.Collections.Generic;
using System.Text;

namespace Reactive.Native.Domain.Entities
{
    public class Cartao
    {
        public Cartao()
        {
            this.CVV = "***";
        }
        public int IdCartao { get; set; }
        public string NumeroCartao { get; set; }
        public DateTime DataValidade { get; set; }
        public string CVV { get;  }
        public string Bandeira { get; set; }
        public string Nome { get; set; }
    }
}
