using System;

namespace Reactive.Native.Domain.Entities
{
    public class Saldo
    {
        public int IdSaldo { get; set; }

        public decimal SaldoDotz { get; set; }
        public decimal SaldoReais { get; set; }
        public DateTime DataSaldo { get; set; }

       
        public string SaldoDate
        {
            get
            {
                DateTime tmp;
                DateTime.TryParse(DataSaldo.ToString(), out tmp);
                return tmp.ToString("MM/dd/yyyy HH:mm:ss");
            }
            set { }
        }

    }
}
