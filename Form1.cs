using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] Nombre = new string[1];
        private void btn_procesar_Click(object sender, EventArgs e)
        {
            //string[] Nombre = new string[1];
            int[] Edad = new int[1];


            for (int i = 0; i < Nombre.Length; i++)
            {
                Nombre[i] = txt_nom.Text;
                Edad[i] = Convert.ToInt32(txt_edad.Text);

            }

            for (int i = 0; i < Nombre.Length; i++)
            {
                cbx_nomyedad.Items.Add(Nombre[i] + " " + Edad[i]);

            }


            //Nombre = Nombre.OrderByDescending(c => c).ToArray();
            //foreach (var item in Nombre)
            //{
            //    cb_Ordenar.Items.Add(item);
            //}

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbx_nomyedad.Sorted = false;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nom.Clear();
            txt_edad.Clear();
            txt_nom.Focus();
        }

        

        private void btn_descendete_Click(object sender, EventArgs e)
        {
            Array.Sort(Nombre);

            Array.Reverse(Nombre);

        }

        private void btn_ascendete_Click(object sender, EventArgs e)
        {
            cbx_nomyedad.Sorted = true;
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro(a) que desea Cerrar del sistema?",
          "Consulta",
          MessageBoxButtons.YesNo,
           MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
