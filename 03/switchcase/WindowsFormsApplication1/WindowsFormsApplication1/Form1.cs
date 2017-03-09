using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class mes : Form
    {
        public mes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbMeses_SelectedIndexChanged(object sender, EventArgs e)
        {

            String Mes = txtMes.Text;
            int nMes = txtMes.SelectedIndex;
            textMes.Text =(string) Convert.ToString(Mes);

            /*switch (nMes)
            {
                case 1:
                    cbMes.Text = textMes.Text;
                    break;
                case 2:
                    cbMes.Text = textMes.Text;
                    break;
                case 3:
                    cbMes.Text = textMes.Text;
                    break;
                case 4:
                    cbMes.Text = textMes.Text;
                    break;
                case 5:
                    cbMes.Text = textMes.Text;
                    break;
                case 6:
                    cbMes.Text = textMes.Text;
                    break;
                case 7:
                    cbMes.Text = textMes.Text;
                    break;
                case 8:
                    cbMes.Text = textMes.Text;
                    break;
                case 9:
                    cbMes.Text = textMes.Text;
                    break;
                case 10:
                    cbMes.Text = textMes.Text;
                    break;
                case 11:
                    cbMes.Text = textMes.Text;
                    break;
                case 12:
                    cbMes.Text = textMes.Text;
                    break;
                default:
                    cbMes.Text = "Nenhum mês associado";
                    break;
     
            }*/
        }
    }
}
