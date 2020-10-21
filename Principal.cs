using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usersValidationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            C_Sharp_12 Class_C12 = new C_Sharp_12();
            Class_C12.ShowDialog();
        }

        private void classToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void finalProjectToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            C_Sharp_12 Class_C12 = new C_Sharp_12();
            Class_C12.ShowDialog();
        }

        private void finalProjectToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://z05.ti400.net/");
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void finalProjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://domingos-ribeiro.github.io/Portfolio-2/");
        }
    }
}
