﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBrasileirao
{
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            InitializeComponent();
        }
        private Bitmap img1;
        private void cmdInserirImagem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img1 = new Bitmap(openFileDialog1.FileName);
                pictureBox2.Image = img1;
            }
            if(pictureBox2.Image!= ProjetoBrasileirao.Properties.Resources.x)
            {
                cmdInserirImagem.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}