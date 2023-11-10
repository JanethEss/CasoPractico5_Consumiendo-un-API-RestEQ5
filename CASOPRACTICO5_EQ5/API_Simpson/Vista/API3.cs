using API_Simpson.Controlador;
using API_Simpson.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Simpson
{
    public partial class API3 : Form
    {
        private CtrlPersSimpson CtrlPersSimpson;
        private PersSimpson PersSimpson;
        public API3()
        {
            InitializeComponent();
            CtrlPersSimpson = new CtrlPersSimpson();
            PersSimpson = new PersSimpson();
        }

        private async void GetPersonajes()
        {
            PersSimpson = await CtrlPersSimpson.GetAllPersSimpson();
            if (PersSimpson != null)
            {
                foreach (var personajesS in PersSimpson?.result)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvPersonajes);

                    row.Cells[0].Value = personajesS.Nombre;
                    row.Cells[1].Value = personajesS.Historia;              
                    // Establecer la propiedad WrapMode para la columna de Historia
                    dgvPersonajes.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                    // Cargar la imagen desde la URL en personaje.image
                    if (!string.IsNullOrEmpty(personajesS.Imagen))
                    {
                        using (var client = new HttpClient())
                        {
                            byte[] imageBytes = await client.GetByteArrayAsync(personajesS.Imagen);
                            Image originalImage = Image.FromStream(new MemoryStream(imageBytes));

                            // Redimensionar la imagen a un tamaño específico (por ejemplo, 100x100)
                            int newWidth = 120;
                            int newHeight = 150;
                            Image resizedImage = new Bitmap(originalImage, newWidth, newHeight);

                            row.Cells[2].Value = resizedImage;
                        }
                    }
                    dgvPersonajes.Rows.Add(row);
                }
            }
            else
            {

            }
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            GetPersonajes();
        }
    }
}
