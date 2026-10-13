using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MunicipalServices.Models;
using MunicipalServices.Services;

namespace MunicipalServices.Forms
{
    public partial class LocalEventsForm : Form
    {
        private const string AllCategories = "All categories";
        private const int MaxRecommendations = 4;

        // Events opened this visit, most recent on top; popping steps back through them.
        private readonly Stack<LocalEvent> _viewHistory = new Stack<LocalEvent>();

        public LocalEventsForm()
        {
            InitializeComponent();
            PopulateFilters();
            DisplayEvents(EventRepository.GetUpcoming(DateTime.Today));
            DisplayAnnouncements();
            RefreshRecommendations();
        }

        private void DisplayAnnouncements()
        {
            announcementsListView.BeginUpdate();
            announcementsListView.Items.Clear();
            foreach (var announcement in AnnouncementRepository.GetByPriority())
            {
                var item = new ListViewItem(announcement.Urgency.ToString().ToUpper())
                {
                    Tag = announcement,
                    ForeColor = UrgencyColor(announcement.Urgency)
                };
                item.SubItems.Add(announcement.Title);
                announcementsListView.Items.Add(item);
            }
            announcementsListView.EndUpdate();

            announcementTextBox.Text = "Select an announcement to read it.";
        }

        private static Color UrgencyColor(AnnouncementUrgency urgency)
        {
            switch (urgency)
            {
                case AnnouncementUrgency.Urgent: return Color.Firebrick;
                case AnnouncementUrgency.Important: return Color.DarkOrange;
                default: return UiTheme.PrimaryDark;
            }
        }

        private void AnnouncementsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (announcementsListView.SelectedItems.Count == 0)
                return;

            var announcement = (Announcement)announcementsListView.SelectedItems[0].Tag;
            announcementTextBox.Text =
                $"{announcement.Title}{Environment.NewLine}" +
                $"Posted {announcement.PostedAt:dd MMM yyyy HH:mm}{Environment.NewLine}{Environment.NewLine}" +
                announcement.Message;
        }

        private void PopulateFilters()
        {
            categoryComboBox.Items.Add(AllCategories);
            foreach (var category in EventRepository.Categories)
                categoryComboBox.Items.Add(category);
            categoryComboBox.SelectedIndex = 0;

            // Only offer dates that actually have events.
            datePicker.MinDate = EventRepository.EventDates.First();
            datePicker.MaxDate = EventRepository.EventDates.Last();
        }

        private void DateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            datePicker.Enabled = dateCheckBox.Checked;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var category = categoryComboBox.SelectedIndex > 0 ? categoryComboBox.Text : null;
            DateTime? date = dateCheckBox.Checked ? datePicker.Value.Date : (DateTime?)null;

            DisplayEvents(EventRepository.Search(category, date));

            RecommendationEngine.Shared.RecordSearch(category);
            RefreshRecommendations();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            categoryComboBox.SelectedIndex = 0;
            dateCheckBox.Checked = false;
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

            OpenEvent((LocalEvent)eventsListView.SelectedItems[0].Tag);
        }

        private void RecommendationsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recommendationsListView.SelectedItems.Count == 0)
                return;

            // The placeholder row (no history yet) has no event attached.
            if (recommendationsListView.SelectedItems[0].Tag is LocalEvent localEvent)
                OpenEvent(localEvent);
        }

        /// <summary>
        /// Shows an event's details, remembers it in the view history, and counts it as a
        /// signal of interest.
        /// </summary>
        private void OpenEvent(LocalEvent localEvent)
        {
            ShowEventDetails(localEvent);

            // Re-selecting the event already on top of the history adds nothing new.
            if (_viewHistory.Count == 0 || _viewHistory.Peek().Id != localEvent.Id)
                _viewHistory.Push(localEvent);
            UpdatePreviousButton();

            RecommendationEngine.Shared.RecordView(localEvent);
            RefreshRecommendations();
        }

        /// <summary>Steps back to the event viewed before the current one.</summary>
        private void PreviousEventButton_Click(object sender, EventArgs e)
        {
            if (_viewHistory.Count < 2)
                return;

            _viewHistory.Pop();
            ShowEventDetails(_viewHistory.Peek());
            UpdatePreviousButton();
        }

        private void UpdatePreviousButton()
        {
            var canGoBack = _viewHistory.Count > 1;
            previousEventButton.Enabled = canGoBack;
            previousEventButton.BackColor = canGoBack ? UiTheme.Primary : UiTheme.Disabled;
            previousEventButton.ForeColor = canGoBack ? UiTheme.TextLight : SystemColors.GrayText;
        }

        private void ShowEventDetails(LocalEvent localEvent)
        {
            detailsTextBox.Text =
                $"{localEvent.Title}{Environment.NewLine}{Environment.NewLine}" +
                $"When: {localEvent.Date:dddd, dd MMMM yyyy 'at' HH:mm}{Environment.NewLine}" +
                $"Where: {localEvent.Location}{Environment.NewLine}" +
                $"Category: {localEvent.Category}{Environment.NewLine}{Environment.NewLine}" +
                localEvent.Description;
        }

        private void RefreshRecommendations()
        {
            var recommendations = RecommendationEngine.Shared.GetRecommendations(
                EventRepository.GetUpcoming(DateTime.Today), DateTime.Today, MaxRecommendations);

            recommendationsListView.BeginUpdate();
            recommendationsListView.Items.Clear();

            if (recommendations.Count == 0)
            {
                var hint = new ListViewItem(RecommendationEngine.Shared.HasHistory
                    ? "No further suggestions right now."
                    : "Search or open events and we'll suggest ones you might like.")
                {
                    ForeColor = SystemColors.GrayText
                };
                recommendationsListView.Items.Add(hint);
            }

            foreach (var recommendation in recommendations)
            {
                var item = new ListViewItem(recommendation.Event.Title) { Tag = recommendation.Event };
                item.SubItems.Add(recommendation.Event.Date.ToString("ddd, dd MMM HH:mm"));
                item.SubItems.Add(recommendation.Reason);
                recommendationsListView.Items.Add(item);
            }

            recommendationsListView.EndUpdate();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
