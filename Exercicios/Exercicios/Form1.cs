using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class Exercicios : Form
    {
        public Exercicios()
        {
            InitializeComponent();
        }

        private void BtnExe1_Click(object sender, EventArgs e)
        {
            var numero = Convert.ToInt32(textMult.Text);
            textResultExe1.Text = (numero * numero).ToString();
             


        }
        private void BtnExe2_Click(object sender, EventArgs e)
        {
            var numA = Convert.ToDouble(textExe2A.Text);
            var numB = Convert.ToDouble(textExe2B.Text);

            textResultExe2.Text = Math.Pow(((numA * 9) / (87 - numB)), 2).ToString();

        }

        private void BtnExe3_Click(object sender, EventArgs e)
        {
            var salAtual = Convert.ToDouble(textSalAtual.Text);
            var reajuste = (Convert.ToDouble(textSalReaj.Text))/100;
            textResultExe3.Text = (salAtual + (salAtual * reajuste)).ToString("C");
            
        }

        private void BtnExe4_Click(object sender, EventArgs e)
        {
            var velMedia = Convert.ToDouble(textVelMedia.Text);
            var tempPerc = TimeSpan.Parse(textTmpViag.Text).TotalHours;
            var distancia = velMedia * tempPerc;
            var kmLitros = 12;
            var litros = distancia / kmLitros;

            textResultExe4.Text = $"A Distancia percorrida foi: {distancia}km e gastou {litros}litros";

        }

        private void BtnExe5_Click(object sender, EventArgs e)
        {
            var salFixo = Convert.ToDouble(textSalFixo.Text);
            var volVendas = Convert.ToDouble(textVolVendas.Text);
            var porcAcrescimo = 0.10;
            var salarioAtuali = (salFixo + (volVendas * porcAcrescimo)).ToString("C");
            textResultExe5.Text = $"O Salario do {textNameFun.Text} este mês é {salarioAtuali}";
        }
    }
}
