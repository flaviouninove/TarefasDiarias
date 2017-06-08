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
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
        }

        private void Listar_Load(object sender, EventArgs e)
        {
            txt1.Text = Tarefas.tar1;
            txt2.Text = Tarefas.tar2;
            txt3.Text = Tarefas.tar3;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
