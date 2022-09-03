using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversordeSegundos
{
    public partial class fmrConverterSegundos : Form
    {
        public fmrConverterSegundos()
        {
            InitializeComponent();
        }


        private void btnConversor_Click(object sender, EventArgs e)
        {
            int valor, horas, minutos, segundos;
            valor = Convert.ToInt32(txtBoxSegundos.Text);

            if (valor >= 60){
                segundos = valor % 60;
                valor = valor / 60;
            }
            else{
                segundos = valor;
                valor = 0;
            }

            if (valor < 60){
                minutos = valor;
                valor = 0;
            }
            else{
                minutos = valor % 60;
                valor = valor / 60;
            }

            if (valor< 60){
                horas = valor;
                valor = 0;
            }
            else{
                horas = valor % 60;
               
            }
            
            lblHora.Visible = true;
            lblHorasRsrultado.Visible = true;
            lblMinutos.Visible = true;
            lblMinutosResultado.Visible = true;
            lblSegundos.Visible = true;
            lblSegundosResultado.Visible = true;

            lblHorasRsrultado.Text = Convert.ToString(horas);
            lblMinutosResultado.Text = Convert.ToString(minutos);
            lblSegundosResultado.Text = Convert.ToString(segundos);
        }

        private void fmrConverterSegundos_Load(object sender, EventArgs e)
        {

        }
    }
}
