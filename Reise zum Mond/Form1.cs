using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reise_zum_Mond
{
    public partial class FormReisezumMond : Form
    {
        private ZeitBerechnung _zeitberechnung = new ZeitBerechnung();
        public FormReisezumMond()
        {
            InitializeComponent();
        }

        private void buttonBerechnen_Click(object sender, EventArgs e)
        {
            int speed = Convert.ToInt32(textBoxSpeed.Text);


            if (radioButtonDays.Checked == true)
            {
                _zeitberechnung.BerechnungDays(speed);

                textBoxResult.Text = _zeitberechnung.TravelTime.ToString()+" d";
            }
            else
            {
                _zeitberechnung.BerechnungHouers(speed);

                textBoxResult.Text = _zeitberechnung.TravelTime.ToString()+" h";
            }

            
        }
    }
}
