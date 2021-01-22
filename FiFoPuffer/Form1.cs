using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiFoPuffer
{
    public partial class Form1 : Form
    {
        FifoPuffer puffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPufferErstellen_Click(object sender, EventArgs e)
        {
            puffer = new FifoPuffer(Convert.ToInt32(numericUpDownPuffergroesse.Value));
        }

        private void buttonPut_Click(object sender, EventArgs e)
        {
            try
            {
                puffer.Put(Convert.ToInt32(textBoxEingabe.Text));
                textBoxEingabe.Clear();
                textBoxEingabe.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBoxEingabe.Clear();
            }
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxAusgabe.Text = puffer.Get().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxAusgabe.Text = puffer.GetAll().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
