using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace Kalender_Forms1
{
    public partial class Kalender : Form
    {
        private string filePath = "events.json";
        private Dictionary<DateTime, string> events;

        public Kalender()
        {
            InitializeComponent();
        }

        private void AnzeigeDatumUndZeit(DateTime dateTime)
        {
            label2.Text = dateTime.ToString("dddd, dd.MM.yyyy HH:mm");
        }

        private void TermineAbrufen_Click(object sender, EventArgs e)
        {

        }

        private void TerminHinzufuegen_Click(object sender, EventArgs e)
        {

        }

        private void TerminVeraendern_Click(object sender, EventArgs e)
        {

        }

        private void TerminLoeschen_Click(object sender, EventArgs e)
        {

        }
    }
}
