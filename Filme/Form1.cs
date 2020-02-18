﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filme
{
    public partial class Form1 : Form
    {
        RadioButton rbnFilme = null;
        RadioButton rbnAssistido = null;
        ListViewItem listitem;
        public Form1()
        {
            InitializeComponent();
        }
        public void SetTipo()
        {

        }
        public void SetSituacao()
        {

        }
        private void rbnFilme_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;
            if (rbn.Checked)
            {
                rbnFilme = rbn;
                SetTipo();
            }
        }
        private void rbnAssistido_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;
            if (rbn.Checked)
            {
                rbnAssistido = rbn;
                SetSituacao();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            listitem = listViewCadastro.Items.Add(txt_Autor.Text);
            listitem.SubItems.Add(txt_genero.Text);
            listitem.SubItems.Add(dateTimePicker1.Text);
            listitem.SubItems.Add(txt_Autor.Text);
            listitem.SubItems.Add(rbnAssistido.Text);
            listitem.SubItems.Add(rbnFilme.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
