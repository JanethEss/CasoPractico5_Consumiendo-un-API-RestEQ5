using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteAPIRest
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnAPI_RyM_Click(object sender, EventArgs e)
        {
            API_RyM.API1 Api1 = new API_RyM.API1();
            Api1.ShowDialog();
            
        }

        private void btnAPI_GobMX_Click(object sender, EventArgs e)
        {
            API_GobMX.API2 Api2 = new API_GobMX.API2();
            Api2.ShowDialog();
        }

        private void btnAPI_Simpson_Click(object sender, EventArgs e)
        {
            API_Simpson.API3 Api3 = new API_Simpson.API3();
            Api3.ShowDialog();
        }
    }
}
