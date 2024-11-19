using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Shared.GameObjects;
using System.Collections.Generic;

namespace Content.Client.UI.Factions
{
    public sealed class FactionUI : FancyWindow
    {
        private readonly VBoxContainer _memberListContainer;
        private Label _factionNameLabel;
        private Label _factionDescriptionLabel;

        public FactionUI()
        {
            Title = "Faction Information";

            // Main layout
            var layout = new VBoxContainer
            {
                Margin = new Thickness(10)
            };

            // Faction name
            _factionNameLabel = new Label
            {
                Text = "Faction Name",
                FontColorOverride = Color.Aqua,
                HorizontalAlignment = HAlignment.Centered,
                StyleClasses = { "FancyLabelBig" }
            };
            layout.AddChild(_factionNameLabel);

            // Faction description
            _factionDescriptionLabel = new Label
            {
                Text = "Faction Description",
                Wrap = true,
                Margin = new Thickness(0, 5, 0, 10)
            };
            layout.AddChild(_factionDescriptionLabel);

            // Member list
            var memberListLabel = new Label
            {
                Text = "Members:",
                FontColorOverride = Color.LimeGreen,
                Margin = new Thickness(0, 10, 0, 5)
            };
            layout.AddChild(memberListLabel);

            _memberListContainer = new VBoxContainer();
            var scrollContainer = new ScrollContainer
            {
                VerticalExpand = true,
                AddChild(_memberListContainer)
            };
            layout.AddChild(scrollContainer);

            // Close button
            var closeButton = new Button
            {
                Text = "Close",
                HorizontalAlignment = HAlignment.Centered,
                Margin = new Thickness(0, 10, 0, 0)
            };
            closeButton.OnPressed += _ => Close();

            layout.AddChild(closeButton);

            Contents.AddChild(layout);
        }

        /// <summary>
        /// Updates the UI with new faction data.
        /// </summary>
        public void UpdateFactionInfo(string factionName, string factionDescription, List<string> members)
        {
            _factionNameLabel.Text = factionName;
            _factionDescriptionLabel.Text = factionDescription;

            // Clear old members and populate with new ones
            _memberListContainer.RemoveAllChildren();
            foreach (var member in members)
            {
                var memberLabel = new Label
                {
                    Text = $"- {member}",
                    FontColorOverride = Color.White
                };
                _memberListContainer.AddChild(memberLabel);
            }
        }
    }
}
