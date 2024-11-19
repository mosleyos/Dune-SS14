using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface;

namespace Content.Client.UI.HUD
{
    public sealed class InteractionMenuUI : Control
    {
        public Button FactionButton { get; }

        public InteractionMenuUI()
        {
            // Создание вертикального контейнера
            var layout = new VBoxContainer
            {
                HorizontalAlignment = HAlignment.Left,
                VerticalAlignment = VAlignment.Center,
                Margin = new Thickness(10)
            };

            // Кнопка для вызова фракционного меню
            FactionButton = new Button
            {
                Text = "Factions",
                HorizontalExpand = true,
                VerticalAlignment = VAlignment.Top,
                StyleClasses = { "InteractionButton" }
            };

            layout.AddChild(FactionButton);
            AddChild(layout);
        }
    }
}
