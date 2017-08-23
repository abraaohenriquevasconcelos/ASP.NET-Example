using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controliti.Modulo.Financeiro.Model
{
    public class ModeloFinanciamento
    {
        List<string> modelos = new List<string>();
        public ModeloFinanciamento()
        {
            modelos.Add("CDC");
            modelos.Add("Leasing");
            modelos.Add("Especial");
            modelos.Add("Crédito");
        }


        public List<String> getModelosFinanciamento()
        {
            return modelos;
        }




    }
}
