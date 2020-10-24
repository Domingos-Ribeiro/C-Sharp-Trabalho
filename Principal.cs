using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            //Elimina a imagem de fundo
            this.BackgroundImage = null;
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            //Depois de quase 3 horas de tentativas, resolvi fazer uma pequena batota para voltar a colocar a imagem que estava antes :))
            this.Hide();
            Principal Geral = new Principal();
            Geral.ShowDialog();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            //As linhas de códigos em baixo são apenas TENTATIVAS FALHADAS para TROCAR a imagem de fundo.

            //string caminho = Application.StartupPath + "\\images\\";//MAIS uma tentativa FALHADA de ir buscar um pasta criada apra o efeito
            //this.BackgroundImage = Image.FromFile(caminho + "C_Sharp_logo_mini.jpg");
            //this.BackgroundImageLayout = ImageLayout.Tile; // Para tentar criar um padrão a partir de uma imagem pequena.
            //this.BackgroundImage = new System.Drawing.Bitmap("C_Sharp_logo_mini.png");
            //this.BackgroundImage = new Bitmap("C_Sharp_logo_mini.png");
            //Principal.BackgroundImage = "C_Sharp_logo_mini.png";
            //this.BackgroundImage.Width.Equals("C_Sharp_logo_mini.png");
            //Principal novo = new Principal();
            //novo.BackgroundImage = "\C_Sharp_logo_mini.png";
            //this.BackgroundImage = ("C_Sharp_logo_mini.jpg");



            //Encontrei este código em baixo na Net que funciona muito bem, já está guardado para um aplicação futura.
            //Não é o que eu queria... mas funciona exatamente para a imagem que criei "fundo.jpg" para fazer um padrão.


            //Embora funcione, não o vou ativar porque é uma cópia integral que alguém fez

            //Principal buscar_imagem = new Principal();
            //OpenFileDialog op = new OpenFileDialog();

            //op.Filter = @"All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG|
            //BMP Files: (*.BMP;*.DIB;*.RLE)|*.BMP;*.DIB;*.RLE|
            //JPEG Files: (*.JPG;*.JPEG;*.JPE;*.JFIF)|*.JPG;*.JPEG;*.JPE;*.JFIF|
            //GIF Files: (*.GIF)|*.GIF|
            //TIFF Files: (*.TIF;*.TIFF)|*.TIF;*.TIFF|
            //PNG Files: (*.PNG)|*.PNG|
            //All Files|*.*";

            //op.ShowDialog();
            //this.BackgroundImage = new Bitmap(op.FileName);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About About = new About();
            About.ShowDialog();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credits creditos = new Credits();
            creditos.ShowDialog();
        }
    }
}
