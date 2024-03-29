﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIncluir fi = new FrmIncluir();
            fi.ShowDialog();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlterar fa = new FrmAlterar();
            fa.ShowDialog();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExcluir fe = new FrmExcluir();
            fe.ShowDialog();
        }

        private void porNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesquisaPorNome fpn = new FrmPesquisaPorNome();
            fpn.ShowDialog();
        }

        private void porCidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesquisaCidade fpc = new FrmPesquisaCidade();
            fpc.ShowDialog();
        }

        private void mnuRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorio fr = new frmRelatorio();
            fr.ShowDialog();
        }
    }
}
