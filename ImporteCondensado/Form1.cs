using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImporteCondensado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();

        }

        private void Calcular()
        {

            var index = 0;
            var numero = Nnumero.Value.ToString().Replace(".", "");
            var factor = Nfactor.Value.ToString();

            var numeroList = numero.ToCharArray().ToList();
            var factorList = factor.ToCharArray().ToList();

            numeroList.Reverse();
        
            var numeroMultiplicando = new List<int>();
            var factorMultiplicador = new List<int>();
            var resultado = new List<int>();


            //Esto se puede optimizar todavia más

            foreach (var item in numeroList)
                numeroMultiplicando.Add(int.Parse(item.ToString()));


            index = 0;
            for (int i = 0; i < numeroList.Count; i++)
            {
                if (index == factor.Length) index = 0;
                factorMultiplicador.Add(int.Parse(factorList[index].ToString()));
                index++;
            }

            index = 0;
            resultado.Clear();
            foreach (var m in numeroMultiplicando)
            {
                resultado.Add(m * factorMultiplicador[index++]);
            }

            Nresultado.Value = resultado.Sum();



        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
