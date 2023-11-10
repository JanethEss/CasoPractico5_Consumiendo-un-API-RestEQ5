using API_RyM.Controlador;
using API_RyM.Modelo;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;

namespace API_RyM
{
    public partial class API1 : Form
    {
        private CtrlPersonajes ctrlPersonajes;
        private Personajes personajes;
        public API1()
        {
            InitializeComponent();
            ctrlPersonajes = new CtrlPersonajes();
            personajes = new Personajes();
        }

        private async void GetPersonajes()
        {
            personajes = await ctrlPersonajes.GetAllPersonajes();
            if (personajes != null)
            {
                foreach(var personajes in personajes?.results){
                    DataGridViewRow roe = new DataGridViewRow();
                    roe.CreateCells(dgvPersonajes);

                    roe.Cells[0].Value = personajes.name;                    
                    roe.Cells[1].Value = personajes.gender;                    
                    roe.Cells[2].Value = personajes.species;                    
                    roe.Cells[3].Value = personajes.origin.name;
                    // Establecer la propiedad WrapMode para la columna de Historia
                    dgvPersonajes.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    // Cargar la imagen desde la URL en personaje.image
                    if (!string.IsNullOrEmpty(personajes.image))
                    {
                        using (var client = new HttpClient())
                        {
                            byte[] imageBytes = await client.GetByteArrayAsync(personajes.image);
                            Image originalImage = Image.FromStream(new MemoryStream(imageBytes));

                            // Redimensionar la imagen a un tamaño específico (por ejemplo, 100x100)
                            int newWidth = 150;
                            int newHeight = 150;
                            Image resizedImage = new Bitmap(originalImage, newWidth, newHeight);

                            roe.Cells[4].Value = resizedImage;
                        }
                    }
                    dgvPersonajes.Rows.Add(roe);
                }
            }
            else
            {

            }
        }

        private void btnObtener_Click_1(object sender, EventArgs e)
        {
            GetPersonajes();

        }
    }
}
