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
        private static string filePath = "events.json";
        public static Dictionary<DateTime, string> Events { get; set; }
        private AddEvent addEventForm;
        private Form2 showEventsForm;
        private ManageEvent manageEventsForm;
        private DeleteEvents deleteEventsForm;

        public Kalender()
        {
            InitializeComponent();
            AnzeigeDatumUndZeit(DateTime.Now);
            Events = LoadEventsFromFile();
        }

        private void AnzeigeDatumUndZeit(DateTime dateTime)
        {
            label2.Text = dateTime.ToString("dddd, dd.MM.yyyy HH:mm");
        }

        private void TermineAbrufen_Click(object sender, EventArgs e)
        {
            showEventsForm = new Form2(Events);
            showEventsForm.Show();
        }

        private void TerminHinzufuegen_Click(object sender, EventArgs e)
        {
            addEventForm = new AddEvent(this);
            addEventForm.Show();
        }

        private void TerminVeraendern_Click(object sender, EventArgs e)
        {
            manageEventsForm = new ManageEvent(Events);
            if (manageEventsForm.ShowDialog() == DialogResult.OK)
            {
                Events = manageEventsForm.GetUpdatedEvents();
                SaveEventsToFile();
            }
        }

        private void TerminLoeschen_Click(object sender, EventArgs e)
        {
            deleteEventsForm = new DeleteEvents(Events);
            deleteEventsForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // wird nicht benutzt
        }

        public static void SaveEventsToFile()
        {
            string json = JsonConvert.SerializeObject(Events);
            File.WriteAllText(filePath, json);
        }

        private Dictionary<DateTime, string> LoadEventsFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<Dictionary<DateTime, string>>(json);
            }
            else
            {
                return new Dictionary<DateTime, string>();
            }
        }

        public static void AddEvent(DateTime date, string eventName)
        {
            Events[date] = eventName;
            SaveEventsToFile();
            MessageBox.Show($"Termin am {date.ToShortDateString()} eingetragen: {eventName}");
        }
    }
}
