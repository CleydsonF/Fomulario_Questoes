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
    public partial class Pergunta4 : Form
    {
        public Pergunta4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtCerto.Checked == true)
            {
                MessageBox.Show("Certa resposta!");
                VariaveisGlobais.Acertos += 1;
                Pergunta5 pergunta5 = new Pergunta5();
                pergunta5.ShowDialog();
                this.Dispose();
            }
            else if (radioButton1.Checked)
            {
                MessageBox.Show("Resposta errada!");
                VariaveisGlobais.Erros += 1;
                Pergunta5 pergunta5 = new Pergunta5();
                pergunta5.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternatva");
            }
        }
    }
}
