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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Vou deixar aqui este comentário para poder usar futuramente
            //Pois descobri como colocar o butão invisivel á martelada
            //Depois de colocar o Backcolor -> Tranparent
            //Flatstyle -> Flat
            //MouseDownBackColor -> Tranparent
            //MouseOverBackColor -> Tranparent
            //UseVisualStyleBackColor -> False
            //É necessário enviar o botão para trás da Label :))
            this.Close();
            
        }
    }
}
