using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryLedoEtapa5
{
    internal class clsVehiculos
    {
        public PictureBox pctAuto;
        public PictureBox pctAvion;
        public PictureBox pctBarco;
        public string tipoVehiculo;

        public void CrearAuto()
        {
            pctAuto = new PictureBox();
            pctAuto.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAuto.Width = 100;
            pctAuto.Height = 100;
            pctAuto.BackColor = Color.Transparent;
            string rutaImagen = Path.Combine(Application.StartupPath, "..", "..", "Resources", "auto.jpg");
            pctAuto.ImageLocation = rutaImagen;
            tipoVehiculo = "Auto";
        }

        public void CrearAvion()
        {
            pctAvion = new PictureBox();
            pctAvion.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAvion.Width = 100;
            pctAvion.Height = 100;
            pctAvion.BackColor = Color.Transparent;
            string rutaImagen = Path.Combine(Application.StartupPath, "..", "..", "Resources", "avion-removebg-preview.png");
            pctAvion.ImageLocation = rutaImagen;
            tipoVehiculo = "Avión";
        }

        public void CrearBarco()
        {
            pctBarco = new PictureBox();
            pctBarco.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBarco.Width = 100;
            pctBarco.Height = 100;
            pctBarco.BackColor = Color.Transparent;
            string rutaImagen = Path.Combine(Application.StartupPath, "..", "..", "Resources", "barco-removebg-preview.png");
            pctBarco.ImageLocation = rutaImagen;
            tipoVehiculo = "Barco";
        }
    }
}
