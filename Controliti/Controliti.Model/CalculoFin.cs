using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controliti.Model
{
    public class CalculoFin
    {

        private double valorFinanc;
        private string modelo;
        private double taxaMensal = 1.12;
        private double fatorRisco;
        private int qtdMeses;
        private double valorParcela;


        public CalculoFin(double valorFinanc, String modelo, double fatorRisco, int qtdMeses)
        {
            this.valorFinanc = valorFinanc;
            this.modelo = modelo;
            this.fatorRisco = fatorRisco;
            this.qtdMeses = qtdMeses;
        }


        public double calculaValorParcela()
        {
            switch (modelo)
            {
                case "CDC":
                    valorParcela = (valorFinanc * taxaMensal * fatorRisco) / qtdMeses;
                    break;
                case "LEA":
                    valorParcela = (valorFinanc * taxaMensal * 1) / qtdMeses;
                    break;
                default:
                    valorParcela = (valorFinanc * taxaMensal * 1) / qtdMeses;
                    break;
            }
            return valorParcela;
        }

        public void aplicaDesconto()
        {
            if (valorFinanc > 10000) taxaMensal = 1.1;
        }



    }
}
