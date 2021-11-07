using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioGuia
{
    public partial class Form1 : Form
    {

        List<Lote> lotes = new List<Lote>();
        Lote lote = new Lote();
        int counter = 1; 
        public Form1()
        {
            InitializeComponent();
            txt_nombre_lote.Text = "Lote #1";
            dgv_piezas_aptas.DataSource = lote.PiezasAptas;
            dgv_piezas_inaptas.DataSource = lote.PiezasInAptas;
        }

        private void btn_empezar_Click(object sender, EventArgs e)
        {
            gb_agregar.Visible = true;
            n_cantidad_procesar.Enabled = false;
            txt_nombre_lote.Enabled = false;
            txt_nombre_pieza.Text = "Pieza #1";

        }
        void UpdatePiezas(string nombre = "inaptas")
        {
            if (nombre == "inaptas")
            {

                dgv_piezas_inaptas.DataSource = null;
                dgv_piezas_inaptas.DataSource = lote.PiezasInAptas;
            } else
            {

                dgv_piezas_aptas.DataSource = null;
                dgv_piezas_aptas.DataSource = lote.PiezasAptas;
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var pieza = new Pieza() 
            {
                Nombre = txt_nombre_pieza.Text.Trim(),
                Longuitud = (double)n_longuitud_pieza.Value
            };
            if (pieza.Longuitud >= 1.20 && pieza.Longuitud <= 1.30)
            {
                lote.PiezasAptas.Add(pieza);
                UpdatePiezas("aptas");
            } else
            {
                lote.PiezasInAptas.Add(pieza);
                UpdatePiezas();
            }
            if (counter == n_cantidad_procesar.Value)
            {
                gb_agregar.Visible = false;
                lote = new Lote();
                n_cantidad_procesar.Enabled = true;
                txt_nombre_lote.Text = $"Lote #{lotes.Count + 1}";
            }
            counter++;
            txt_nombre_pieza.Text = $"Pieza #{counter}";


        }

        
    }
}
