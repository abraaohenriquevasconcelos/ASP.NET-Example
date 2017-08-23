using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controliti.Model;
using Controliti.Modulo.Financeiro.Model;


namespace Controliti.Modulo.Financeiro.View
{
    public partial class wfFinanciamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                carregaModelosFinanciamento();
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alerte1", "alert('O professor é muito chato!'); confirm('Tem certeza?');", true);
            }


        }

        public wfFinanciamento()
        {
            //"this.Load += new EventHandler(LoadDate)" = para esta própria página no evento "Load" dela, acrescente ao evento "Load", o evento "LoadDate"
            //delegate void System.EventHandler()
            this.Load += new EventHandler(LoadDate);
            //para esta própria página no evento "PreRender" dela, acrescente o evento "SaveDate"
            this.PreRender += new EventHandler(SaveDate);
        }

        void LoadDate(object sender, EventArgs e)
        {
            //Mesmo que a propriedade "EnableViewState="false"" do controle "asp:Calendar" esteja com o valor "false" este método vai recuperar
            //o estado do controle graças ao "ViewState["DataEscolhida"]"
            //Então estamos guardando o "ViewState" de um controle manualmente
            if (IsPostBack)
            {
                //Estamos lendo e convertendo a variável de memória "DataEscolhida" para "DateTime" e jogando ela para o Calendário
                Calendar1.SelectedDate = Convert.ToDateTime(ViewState["DataEscolhida"]);
            }
        }

        void SaveDate(object sender, EventArgs e)
        {
            ViewState["DataEscolhida"] = Calendar1.SelectedDate;
        }


        protected void criarFinanciamento_OnClick(object sender, EventArgs e)
        {
            CalculoFin calculoFin = new CalculoFin(Convert.ToDouble(valorFinanciamento.Text), dropDownListModeloFinanciamento.Text, Convert.ToDouble(taxaRisco.Text), Convert.ToInt32(qtdParcelas.Text));


            if (checkBoxDesconto.Checked)
                calculoFin.aplicaDesconto();


            valorParcela.Text = Convert.ToString( String.Format("{0:C2}",calculoFin.calculaValorParcela()) );
            valorTotalFinal.Text = Convert.ToString( String.Format("{0:C2}", calculoFin.calculaValorParcela() * Convert.ToInt32(qtdParcelas.Text)) );
        }


        protected void carregaModelosFinanciamento()
        {

            ModeloFinanciamento modeloFinanc = new ModeloFinanciamento();

            /*ListControl.AppendDataBoundItems ->  define um valor que indica se os itens da lista são apagados antes da vinculação de dados. */
            dropDownListModeloFinanciamento.AppendDataBoundItems = true;
            /*BaseDataBoundControl.DataSource -> An object that represents the data source (fonte de dados) from which  the data-bound control (o controle com limite de dados)
              retrieves its data*/
            dropDownListModeloFinanciamento.DataSource = modeloFinanc.getModelosFinanciamento();
            /*Use este método para vincular dados de uma fonte a um controle de servidor.*/
            dropDownListModeloFinanciamento.DataBind();
        }

      

        protected void Calendar1_OnSelectionChanged(object sender, EventArgs e)
        {

        }
    }
}