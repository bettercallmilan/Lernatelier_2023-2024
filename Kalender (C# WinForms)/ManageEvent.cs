using Newtonsoft.Json;
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
    public partial class ManageEvent : Form
    {
        private Dictionary<DateTime, string> events;

        public ManageEvent(Dictionary<DateTime, string> events)
        {
            InitializeComponent();

            this.events = events;

            foreach (var entry in events)
            {
                listBoxEvents.Items.Add($"{entry.Key.ToShortDateString()}: {entry.Value}");
            }
        }

        public Dictionary<DateTime, string> GetUpdatedEvents()
        {
            return events;
        }

        public void UpdateEventList(Dictionary<DateTime, string> updatedEvents)
        {
            events = updatedEvents;
        }


        private void btnEditEvent_Click_1(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedIndex != -1)
            {
                string selectedEvent = listBoxEvents.SelectedItem.ToString();
                DateTime selectedDate = DateTime.Parse(selectedEvent.Split(':')[0]);

                EditEventForm editForm = new EditEventForm(selectedDate, events[selectedDate]);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    events[selectedDate] = editForm.NewEventText;
                    listBoxEvents.Items[listBoxEvents.SelectedIndex] = $"{selectedDate.ToShortDateString()}: {events[selectedDate]}";

                    this.Close();

                    Kalender.SaveEventsToFile();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}