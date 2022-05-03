using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_6._2_WindowsForms_Exercicio_03_05
{
    public partial class Pergunta1 : Form
    {
        public Pergunta1()
        {
            InitializeComponent();
        }

        private void btnProximo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtCerto.Checked == true)
            {
                MessageBox.Show("Certa resposta!");
                VariaveisGlobais.Acertos += 1;
                Pergunta2 pergunta2 = new Pergunta2();
                pergunta2.ShowDialog();
                this.Dispose();
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Resposta errada!");
                VariaveisGlobais.Erros +=1;
                Pergunta2 pergunta2 = new Pergunta2();
                pergunta2.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternatva");
            }
            
        }
    }
}
