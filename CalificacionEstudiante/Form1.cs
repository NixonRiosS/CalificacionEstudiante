using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalificacionEstudiante
{
    public partial class btn_limpiar : Form
    {
        public btn_limpiar()
        {
            InitializeComponent();
        }

        private void txt_nota1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (txt_nota1.Text == "" || txt_nota2.Text == "" || txt_nota3.Text == "" || txt_nota4.Text == "")
            {
                MessageBox.Show("Todos los campos deben estar diligenciados", "Mensaje de validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else {
                double nota1, nota2, nota3, nota4, suma, resultado;
                nota1 = double.Parse(txt_nota1.Text);
                nota2 = double.Parse(txt_nota2.Text);
                nota3 = double.Parse(txt_nota3.Text);
                nota4 = double.Parse(txt_nota4.Text);

                suma = nota1 + nota2 + nota3 + nota4;

                resultado = suma / 4;

                lbl_resultado.Text = Convert.ToString(resultado);

                lbl_promedio.Visible = true;
                lbl_resultado.Visible = true;
            }
            

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            txt_nota1.Text = String.Empty;
            txt_nota2.Text = String.Empty;
            txt_nota3.Text = String.Empty;
            txt_nota4.Text = String.Empty;
            
            lbl_promedio.Visible = false;
            lbl_resultado.Visible = false;

            txt_nota1.Focus();

        }
    }
}
