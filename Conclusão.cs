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
    public partial class Conclusão : Form
    {
        public Conclusão()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Conclusão_Load(object sender, EventArgs e)
        {
            lblAcertos.Text = VariaveisGlobais.Acertos.ToString();
            lblErradas.Text = VariaveisGlobais.Erros.ToString();
        }
    }
}
