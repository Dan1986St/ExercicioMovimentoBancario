using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    class AuditoriaBancaria
    {
        public TipoOperacao Tipo { get; set; }
        public double Quantia { get; set; }
        public DateTime DataOperacao { get; private set; }
        public double SaldoPosOperacao { get; set; }

        public AuditoriaBancaria()
        {
            this.DataOperacao = DateTime.Now;
        }

        public override string ToString()
        {
            return "Tipo: " + this.Tipo + "\r\n" +
                   "Quantia: " + this.Quantia.ToString("C2") + "\r\n" +
                   "Data: " + this.DataOperacao.ToString("dd/MM/yyyy - HH:mm:ss") + "\r\n" +
                   "Saldo: " + this.SaldoPosOperacao.ToString("C2") + "\r\n";
        }

    }
}
