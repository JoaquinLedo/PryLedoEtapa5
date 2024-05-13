using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryLedoEtapa5
{
    public partial class Form1 : Form
    {
        // Declarar variables para la posición X e Y de los controles
        int x;
        int y;
        // Declarar variables para el ancho y el alto del formulario
        int formWidth;
        int formHeight;

        public Form1()
        {
            InitializeComponent();
            // Obtener el ancho y el alto del formulario
            formWidth = this.ClientSize.Width;
            formHeight = this.ClientSize.Height;
        }

        clsVehiculos objAuto;
        clsVehiculos objAvion;
        clsVehiculos objBarco;

        bool Auto = false;
        bool Avion = false;
        bool Barco = false;
        Random random = new Random();

        private void BtnVehiculosAleatorios_Click(object sender, EventArgs e)
        {
            LblBarco.Visible = true;
            lblAuto.Visible = true;
            lblAvion.Visible = true;
            x = random.Next(formWidth - objAuto.pctAuto.Width);
            y = random.Next(formHeight - objAuto.pctAuto.Height);
            // Limpiar los textos de los labels
            lblAuto.Text = "";
            lblAvion.Text = "";
            LblBarco.Text = "";

            // Eliminar los PictureBox existentes si ya están creados
            if (objAuto.pctAuto != null && objAuto.pctAuto.Parent != null)
            {
                Controls.Remove(objAuto.pctAuto);
                Controls.Remove(lblAuto);
            }
            if (objAvion.pctAvion != null && objAvion.pctAvion.Parent != null)
            {
                Controls.Remove(objAvion.pctAvion);
                Controls.Remove(lblAvion);
            }
            if (objBarco.pctBarco != null && objBarco.pctBarco.Parent != null)
            {
                Controls.Remove(objBarco.pctBarco);
                Controls.Remove(LblBarco);
            }

            // Generar coordenadas X e Y aleatorias
            x = random.Next(this.Width - 100); // Ancho del formulario
            y = random.Next(this.Height - 200); // Alto del formulario 

            int numeroAleatorio = random.Next(1, 4);

            switch (numeroAleatorio)
            {
                case 1:
                    objAuto.CrearAuto();
                    objAuto.pctAuto.Location = new Point(x, y);
                    Controls.Add(objAuto.pctAuto);
                    lblAuto.Text = objAuto.tipoVehiculo;
                    lblAuto.AutoSize = true;
                    lblAuto.Location = new Point(x, y + objAuto.pctAuto.Height);
                    Controls.Add(lblAuto);
                    break;

                case 2:
                    objAvion.CrearAvion();
                    objAvion.pctAvion.Location = new Point(x, y);
                    Controls.Add(objAvion.pctAvion);
                    lblAvion.Text = objAvion.tipoVehiculo;
                    lblAvion.AutoSize = true;
                    lblAvion.Location = new Point(x, y + objAvion.pctAvion.Height);
                    Controls.Add(lblAvion);
                    break;

                case 3:
                    objBarco.CrearBarco();
                    objBarco.pctBarco.Location = new Point(x, y);
                    Controls.Add(objBarco.pctBarco);
                    LblBarco.Text = objBarco.tipoVehiculo;
                    LblBarco.AutoSize = true;
                    LblBarco.Location = new Point(x, y + objBarco.pctBarco.Height);
                    Controls.Add(LblBarco);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objAuto = new clsVehiculos();
            objAvion = new clsVehiculos();
            objBarco = new clsVehiculos();

            objAuto.CrearAuto();
            objAvion.CrearAvion();
            objBarco.CrearBarco();
        }
    }
}
