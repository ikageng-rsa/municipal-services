using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MunicipalServices.Models;

namespace MunicipalServices.Forms
{
    public partial class LocalEventsForm : Form
    {
        public LocalEventsForm()
        {
            InitializeComponent();
            DisplayEvents(EventRepository.GetUpcoming(DateTime.Today));
        }

        private void DisplayEvents(IEnumerable<LocalEvent> events)
        {
            var list = events.ToList();

            eventsListView.BeginUpdate();
            eventsListView.Items.Clear();
            foreach (var localEvent in list)
            {
                var item = new ListViewItem(localEvent.Date.ToString("ddd, dd MMM HH:mm"))
                {
                    Tag = localEvent
                };
                item.SubItems.Add(localEvent.Title);
                item.SubItems.Add(localEvent.Category);
                item.SubItems.Add(localEvent.Location);
                eventsListView.Items.Add(item);
            }
            eventsListView.EndUpdate();

            statusLabel.Text = list.Count == 1 ? "Showing 1 event" : $"Showing {list.Count} events";
            detailsTextBox.Text = list.Count == 0
                ? "No events found."
                : "Select an event to see its details.";
        }

        private void EventsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventsListView.SelectedItems.Count == 0)
                return;

            var localEvent = (LocalEvent)eventsListView.SelectedItems[0].Tag;
            detailsTextBox.Text =
                $"{localEvent.Title}{Environment.NewLine}{Environment.NewLine}" +
                $"When: {localEvent.Date:dddd, dd MMMM yyyy 'at' HH:mm}{Environment.NewLine}" +
                $"Where: {localEvent.Location}{Environment.NewLine}" +
                $"Category: {localEvent.Category}{Environment.NewLine}{Environment.NewLine}" +
                localEvent.Description;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
