using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tannenbaumzeichnen
{
    public partial class Tannenbaumzeichnen : Form
    {
        public Tannenbaumzeichnen()
        {   
            InitializeComponent();
        }

        private void buttondraw_Click(object sender, EventArgs e)
        {
            Tanne tanne = new Tanne(Convert.ToInt32(textBoxCrownHight.Text),
                Convert.ToInt32(textBoxWidth.Text),
                Convert.ToInt32(textBoxHight.Text));
            
            tanne.Zeichne();
            textBoxTree.Text = tanne.Resultat;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
