﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_contactos
{
    public partial class frmCrearContacto : Form
    {
        public frmCrearContacto()
        {
            InitializeComponent();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                pbCargarImagen.ImageLocation = abrirImagen.FileName;
                pbCargarImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }

        private void pbCargarImagen_Click(object sender, EventArgs e)
        {

        }

        private void txtnombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCrearContacto_Load(object sender, EventArgs e)
        {

        }
    }
}
