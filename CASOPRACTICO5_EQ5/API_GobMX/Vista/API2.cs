using API_GobMX.Controlador;
using API_GobMX.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_GobMX
{
    public partial class API2 : Form
    {
        private CtrlDatos ctrlDatos;
        private Datos datos;
        public API2()
        {
            InitializeComponent();
            ctrlDatos = new CtrlDatos();
            datos = new Datos();
        }

        private async void GetDatos()
        {
            datos = await ctrlDatos.GetAllDatos();
            if (datos != null)
            {
                foreach (var datos in datos?.results)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvDatos);

                    row.Cells[0].Value = datos.organization;
                    row.Cells[1].Value = datos.fact;
                    // Establecer la propiedad WrapMode para la columna de Historia
                    dgvDatos.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    row.Cells[2].Value = datos.operations;
                    row.Cells[3].Value = datos.url;                  
                    dgvDatos.Rows.Add(row);
                }
            }
            else
            {

            }
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            GetDatos();
        }
    }
}
