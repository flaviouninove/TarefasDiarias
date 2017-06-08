using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarefasDiarias
{
    public partial class Tarefas : Form
    {
        public string tar1, tar2, tar3;

        public Tarefas()
        {
            InitializeComponent();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            tar1 = txt1.Text;
            tar2 = txt2.Text;
            tar3 = txt3.Text;

            MessageBox.Show("Tarefas adicionadas!");
            Hide();
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            var list = new Listar();
            list.ShowDialog();
        }
    }
}
