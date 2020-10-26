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
    public partial class C_Sharp_12 : Form
    {
        public C_Sharp_12()
        {
            InitializeComponent();
            //this.Show();
            Aviso_C_12 aviso = new Aviso_C_12();
            aviso.ShowDialog();
            
            cmdRemover.Enabled = false;
            btn_Selec_um.Enabled = false;
            btn_Selec_todos.Enabled = false;
            btn_Voltar_um.Enabled = false;
            btn_Voltar_todos.Enabled = false;
            //Aqui o "Focus" não funciona... pela minha lógica deveveria.
            //O Visual Code sugeriu colocar a variável v boleana mas também não funcionou.
            //bool v = txtNome.Focus();
        }

        private void cmdAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                lstUtilizadores.Items.Add(txtNome.Text);
                txtNome.Text = "";
                txtNome.Focus();

                //Logo que seja adicionado um utilizador, ativa o botão "Remover"
                if (lstUtilizadores.Items.Count >= 0)
                {
                    cmdRemover.Enabled = true;
                    btn_Selec_um.Enabled = true;
                    btn_Selec_todos.Enabled = true;
                }

            }
            else
            {
                //MessageBox.Show(texto da mensagem, titulo da janela, tipo de botões, tipo icons)
                MessageBox.Show("Por favor digite um Nome", "Erro, Não foi selecionado um Nome", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Conta ativos, suspensos e totais
            txt_ativos.Text = Convert.ToString(lstUtilizadores.Items.Count);
            txt_suspensos.Text = Convert.ToString(lstSuspensos.Items.Count);
            txt_total.Text = Convert.ToString(lstUtilizadores.Items.Count + lstSuspensos.Items.Count);

        }

        private void btn_Selec_um_Click(object sender, EventArgs e)
        {
            int pos = lstUtilizadores.SelectedIndex;
            if (pos > -1)
            {
                String nome = lstUtilizadores.SelectedItem.ToString();
                lstSuspensos.Items.Add(nome);
                lstUtilizadores.Items.Remove(nome);
            }
            else
                MessageBox.Show("Por favor selecione um Nome", "Erro: Nome não selecionado!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Conta ativos, suspensos e totais
            txt_ativos.Text = Convert.ToString(lstUtilizadores.Items.Count);
            txt_suspensos.Text = Convert.ToString(lstSuspensos.Items.Count);
            txt_total.Text = Convert.ToString(lstUtilizadores.Items.Count + lstSuspensos.Items.Count);

            //Inviabiliza o botão "Remover" se a lista estiver vazia.
            if (lstUtilizadores.Items.Count <= 0)
            {
                cmdRemover.Enabled = false;
                //cmdRemover.BackColor = Color.Red;
            }

            if (lstUtilizadores.Items.Count <= 0)
            {
                btn_Selec_um.Enabled = false;
                //btn_Voltar_um.BackColor = Color.Red;
                btn_Selec_todos.Enabled = false;
                //btn_Voltar_todos.BackColor = Color.Red;
            }

            if (lstSuspensos.Items.Count >= 0)
            {
                btn_Voltar_um.Enabled = true;
                btn_Voltar_todos.Enabled = true;
            }
        }

        private void btn_Selec_todos_Click(object sender, EventArgs e)
        {
            lstSuspensos.Items.AddRange(lstUtilizadores.Items);
            lstUtilizadores.Items.Clear();

            //Conta ativos, suspensos e totais
            txt_ativos.Text = Convert.ToString(lstUtilizadores.Items.Count);
            txt_suspensos.Text = Convert.ToString(lstSuspensos.Items.Count);
            txt_total.Text = Convert.ToString(lstUtilizadores.Items.Count + lstSuspensos.Items.Count);


            //Inviabiliza o botão "Remover" se a lista estiver vazia.
            if (lstUtilizadores.Items.Count <= 0)
            {
                cmdRemover.Enabled = false;
            }

            if (lstUtilizadores.Items.Count <= 0)
            {
                btn_Selec_um.Enabled = false;
                //btn_Voltar_um.BackColor = Color.Red;
                btn_Selec_todos.Enabled = false;
                //btn_Voltar_todos.BackColor = Color.Red;
            }

            if (lstSuspensos.Items.Count >= 0)
            {
                btn_Voltar_um.Enabled = true;
                btn_Voltar_todos.Enabled = true;
            }
        }

        private void btn_Voltar_um_Click(object sender, EventArgs e)
        {
            int pos = lstSuspensos.SelectedIndex;
            if (pos > -1)
            {
                String nome = lstSuspensos.SelectedItem.ToString();
                lstUtilizadores.Items.Add(nome);
                lstSuspensos.Items.Remove(nome);
            }
            else
                MessageBox.Show("Por favor selecione um Nome", "Erro: Nome não selecionado!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Conta ativos, suspensos e totais
            txt_ativos.Text = Convert.ToString(lstUtilizadores.Items.Count);
            txt_suspensos.Text = Convert.ToString(lstSuspensos.Items.Count);
            txt_total.Text = Convert.ToString(lstUtilizadores.Items.Count + lstSuspensos.Items.Count);

            //Logo que seja adicionado um utilizador, ativa o botão "Remover"
            if (lstUtilizadores.Items.Count >= 0)
            {
                cmdRemover.Enabled = true;
                
            }

            if (lstSuspensos.Items.Count <= 0)
            {
                btn_Voltar_um.Enabled = false;
                //btn_Voltar_um.BackColor = Color.Red;
                btn_Voltar_todos.Enabled = false;
                //btn_Voltar_todos.BackColor = Color.Red;
            }

            if (lstUtilizadores.Items.Count >= 0)
            {
                btn_Selec_um.Enabled = true;
                btn_Selec_todos.Enabled = true;
            }
        }

        private void btn_Voltar_todos_Click(object sender, EventArgs e)
        {
            lstUtilizadores.Items.AddRange(lstSuspensos.Items);
            lstSuspensos.Items.Clear();

            //Conta ativos, suspensos e totais
            txt_ativos.Text = Convert.ToString(lstUtilizadores.Items.Count);
            txt_suspensos.Text = Convert.ToString(lstSuspensos.Items.Count);
            txt_total.Text = Convert.ToString(lstUtilizadores.Items.Count + lstSuspensos.Items.Count);

            if (lstUtilizadores.Items.Count >= 0)
            {
                cmdRemover.Enabled = true;
            }

            if (lstSuspensos.Items.Count <= 0)
            {
                //Caso não exista ninguém na lista de suspensos, invabiliza os botões e pinta-os de vermelho
                //RETIREI A PARTE dos botões ficarem vermelhos... são demasiados floriados :))
                btn_Voltar_todos.Enabled = false;
                //btn_Voltar_todos.BackColor = Color.Red;
                btn_Voltar_um.Enabled = false;
                //btn_Voltar_um.BackColor = Color.Red;
            }

            if (lstUtilizadores.Items.Count >= 0)
            {
                btn_Selec_um.Enabled = true;
                btn_Selec_todos.Enabled = true;
            }
        }

        private void cmdRemover_Click(object sender, EventArgs e)
        {
            if (lstUtilizadores.SelectedIndex > -1)
            {
                if (MessageBox.Show("tem a certeza que quer remover \no Nome selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lstUtilizadores.Items.RemoveAt(lstUtilizadores.SelectedIndex);

                    //Inviabiliza o botão "Remover" se a lista estiver vazia.
                    
                    
                    if (lstUtilizadores.Items.Count <= 0)
                    {
                        cmdRemover.Enabled = false;
                        //cmdRemover.BackColor = Color.Red;
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione um Nome", "Erro: Nome não selecionado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Conta ativos, suspensos e totais
            txt_ativos.Text = Convert.ToString(lstUtilizadores.Items.Count);
            txt_suspensos.Text = Convert.ToString(lstSuspensos.Items.Count);
            txt_total.Text = Convert.ToString(lstUtilizadores.Items.Count + lstSuspensos.Items.Count);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Principal geral = new Principal();
            geral.ShowDialog();

        }

        private void C_Sharp_12_Load(object sender, EventArgs e)
        {

        }
    }
}
