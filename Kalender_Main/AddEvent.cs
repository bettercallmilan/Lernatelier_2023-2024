using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Kalender_Forms1
{
    public partial class AddEvent : Form
    {
        private Kalender parentForm;

        public AddEvent(Kalender parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.Select();
        }

        private void AddEventConfirmed()
        {
            string userInputDate = textBoxDate.Text;
            string userInputEvent = textBoxEvent.Text;

            if (DateTime.TryParse(userInputDate, out DateTime date))
            {
                if (!string.IsNullOrWhiteSpace(userInputEvent))
                {
                    Kalender.AddEvent(date, userInputEvent);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Der Termin darf nicht leer sein. Bitte geben Sie einen gültigen Termin ein.");
                }
            }
            else
            {
                MessageBox.Show("Ungültiges Datumsformat. Bitte verwenden Sie das Format JJJJ-MM-TT.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEventConfirmed();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
