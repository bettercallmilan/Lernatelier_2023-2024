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
    public partial class Form2 : Form
    {
        private Dictionary<DateTime, string> events;

        public Form2(Dictionary<DateTime, string> events)
        {
            InitializeComponent();

            this.events = events;

            listBox1.Items.Clear();
            if (this.events.Count > 0)
            {
                foreach (var item in this.events)
                {
                    listBox1.Items.Add($"{item.Key.ToShortDateString()} - {item.Value}");
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // wird nicht benutzt
        }
    }
}
