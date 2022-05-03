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
    public partial class Pergunta2 : Form
    {
        public Pergunta2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtCerta.Checked == true)
            {
                MessageBox.Show("Certa resposta!");
                VariaveisGlobais.Acertos += 1;
                Pergunta3 pergunta3 = new Pergunta3();
                pergunta3.ShowDialog();
                this.Dispose();
            }
            else if (radioButton1.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Resposta errada!");
                VariaveisGlobais.Erros += 1;
                Pergunta3 pergunta3 = new Pergunta3();
                pergunta3.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternatva");
            }
        }
    }
}
