using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alterberechnen
{
    public partial class alterBerechnen : Form
    {
        private AlterBerechnen _alterberechnen = new AlterBerechnen();
        public alterBerechnen()
        {
            InitializeComponent();
        }

        private void buttonBerechnen_Click(object sender, EventArgs e)
        {
            DateTime birthdate = dateTimePicker.Value;

            if (radioButtonDays.Checked == true)
            {
                _alterberechnen.calculatedays(birthdate);
                textBoxAge.Text = _alterberechnen.Age.ToString();
            }
            else if (radioButtonWeeks.Checked == true)
            {
                _alterberechnen.calculateweeks(birthdate);
                textBoxAge.Text = _alterberechnen.Age.ToString();
            }
            else if (radioButtonMonths.Checked == true)
            {
                _alterberechnen.calculatemonths(birthdate);

                textBoxAge.Text = _alterberechnen.Age.ToString();
            }
            else if (radioButtonYears.Checked == true)
            {
                _alterberechnen.calculateyears(birthdate);

                textBoxAge.Text = _alterberechnen.Age.ToString();
            }
            else
            {
                textBoxAge.Text = "Bitte wählen Sie eine Einheit aus";
            }
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
