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
    public partial class Tips : Form
    {
        public Tips()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Principal geral = new Principal();
            geral.ShowDialog();
        }
    }
}
