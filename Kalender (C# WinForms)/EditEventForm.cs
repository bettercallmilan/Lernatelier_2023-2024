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
    public partial class EditEventForm : Form
    {
        private ManageEvent parentForm;

        private string eventText;

        public string NewEventText { get; private set; }

        public EditEventForm(DateTime eventDate, string eventText)
        {
            InitializeComponent();

            this.eventText = eventText;

            txtEventText.Text = eventText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewEventText = txtEventText.Text;
            this.DialogResult = DialogResult.OK;

            if (parentForm != null)
            {
                parentForm.UpdateEventList(parentForm.GetUpdatedEvents());
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
