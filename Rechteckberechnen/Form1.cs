using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechteckberechnen
{
	public partial class Form1 : Form
	{
		private Rechtecksberechnung _rechteckberechnung = new Rechtecksberechnung();
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        private void buttonBerechnen_Click(object sender, EventArgs e)
        {
			int rechteckshoehe = Convert.ToInt32(textHoehe.Text);
			int rechtecksbreite = Convert.ToInt32(textBreite.Text);

			try
            {
				_rechteckberechnung.Berechnung(rechteckshoehe, rechtecksbreite);
            }
			catch (Exception ex)
            {
				MessageBox.Show("Fehler: " + ex.Message);
            }
			textFlaeche.Text = _rechteckberechnung.Rechtecksflaeche.ToString();
        }

    }
}
