using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            






            //struct vs class
            //Structs - bool int, double, float, decimal, char 
            //Pessoa douglas = new Pessoa();
            //douglas.Idade = 25;

            //Pessoa celo = new Pessoa();
            //celo.Idade = 32;

            //celo = douglas;

            //celo.Idade = 30;

            //MessageBox.Show(celo.Idade.ToString());

            Pessoa brunella = new Pessoa();
            brunella.Idade = 23;

            SilvioSantos ss = new SilvioSantos();
            ss.Amaldicoar(brunella.Idade);

            //ss.Maldicao(brunella);


            ContaBancaria cc = new ContaBancaria("123456", "147258369");
            RespostaOperacaoBancaria respostaDeposito = cc.Depositar(2000);
            //if (!respostaDeposito.Sucesso)
            //{
            //    MessageBox.Show(respostaDeposito.Mensagem);
            //}
            Thread.Sleep(3000);
            RespostaOperacaoBancaria respostaSaque = cc.Sacar(1500);
            cc.Sacar(2000);
            Thread.Sleep(3000);


            cc.Depositar(5000);
            Thread.Sleep(3000);

            cc.Sacar(300);


            MessageBox.Show(cc.LerSaldo());

            MessageBox.Show(cc.LerExtrato());


        }
    }

}
