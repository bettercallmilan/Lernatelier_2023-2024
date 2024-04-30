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
            
        }
    }
}
