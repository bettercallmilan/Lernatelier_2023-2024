using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalender_Forms1
{
    public partial class DeleteEvents : Form
    {
        private Kalender parentForm;

        private Dictionary<DateTime, string> events;

        public DeleteEvents(Dictionary<DateTime, string> events)
        {
            InitializeComponent();
            this.Select();

            this.events = events;

            foreach (var entry in events)
            {
                listBox1.Items.Add($"{entry.Key.ToShortDateString()}: {entry.Value}");
            }
        }

        private void DeleteEventConfirmed()
        {
            if (listBox1.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Möchten Sie das ausgewählte Ereignis wirklich löschen?", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string selectedEvent = listBox1.SelectedItem.ToString();
                    DateTime selectedDate = DateTime.Parse(selectedEvent.Split(':')[0]);

                    events.Remove(selectedDate);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                    Kalender.SaveEventsToFile();
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie ein Ereignis zum Löschen aus.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteEventConfirmed();
        }
    }
}
