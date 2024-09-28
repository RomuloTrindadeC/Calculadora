using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc2
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //Criação da propriedade resultado da operação matematica
        public decimal ResultadoOperacao { get; set; }
        public decimal Valores { get; set; }


        //Criação dessa propriedade para que ao selecionar a operação desejada, o próximo número seja recebido
        private Operacao OperacaoSelecionada { get; set; }

        public enum Operacao
            {
                Adicao,
                Subtracao,
                Multiplicacao,
                Divisao,
            }


        private void Bt1_Click(object sender, EventArgs e)
        {
            TxtBx_Visor.Text += 1;
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            TxtBx_Visor.Text += 2;
        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            TxtBx_Visor.Text += 3;
        }

        private void Bt4_Click(object sender, EventArgs e)
        {
            TxtBx_Visor.Text += 4;
        }

        private void Bt5_Click(object sender, EventArgs e)
        {
            TxtBx_Visor.Text += 5;
        }

        private void Bt6_Click(object sender, EventArgs e)
        {
            TxtBx_Visor.Text += 6;
        }

        private void Bt7_Click(object sender, EventArgs e)
        {
            TxtBx_Visor.Text += 7;
        }

        private void Bt8_Click(object sender, EventArgs e)
        {
            TxtBx_Visor.Text += 8;
        }

        private void Bt9_Click(object sender, EventArgs e)
        {
            TxtBx_Visor.Text += 9;
        }

        private void Bt0_Click(object sender, EventArgs e)
        {
            TxtBx_Visor.Text += 0;
        }

        private void BtnVirgula_Click(object sender, EventArgs e)
        {
            if (!TxtBx_Visor.Text.Contains(","))
                TxtBx_Visor.Text += ",";
        }

        //Mapeamento das operações matemáticas e o que fazer quando esta operação for selecionada
        //Note que nesse caso, o visor ficará vazio para receber o próximo número e prosseguir com a conta
        private void BtMais_Click(object sender, EventArgs e)
        {
            //TxtBx_Visor.Text += " + ";
            OperacaoSelecionada = Operacao.Adicao;
            Valores = Convert.ToDecimal(TxtBx_Visor.Text);
            TxtBx_Visor.Text = "";
        }

        private void BtMenos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valores = Convert.ToDecimal(TxtBx_Visor.Text);
            TxtBx_Visor.Text = "";
        }

        private void BtMult_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valores = Convert.ToDecimal(TxtBx_Visor.Text);
            TxtBx_Visor.Text = "";
        }

        private void BtDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valores = Convert.ToDecimal(TxtBx_Visor.Text);
            TxtBx_Visor.Text = "";
        }

        public void BtCalcula_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    ResultadoOperacao = Valores + Convert.ToInt16(TxtBx_Visor.Text);
                    break;
                case Operacao.Subtracao:
                    ResultadoOperacao = Valores + Convert.ToInt16(TxtBx_Visor.Text);
                    break;
                case Operacao.Multiplicacao:
                    ResultadoOperacao = Valores + Convert.ToInt16(TxtBx_Visor.Text);
                    break;
                case Operacao.Divisao:
                    ResultadoOperacao = Valores + Convert.ToInt16(TxtBx_Visor.Text);
                    break;
            }
            TxtBx_Visor.Text = Convert.ToString(ResultadoOperacao);

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtBx_Visor.Text = "";
        }
        
    }
}
