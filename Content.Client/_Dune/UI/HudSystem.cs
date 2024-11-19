using Robust.Client.UserInterface;
using Content.Client.UI.Factions;

namespace Content.Client.UI.HUD
{
    public sealed class HudSystem : EntitySystem
    {
        private InteractionMenuUI? _interactionMenu;
        private FactionUIManager? _factionUIManager;

        public override void Initialize()
        {
            base.Initialize();

            _factionUIManager = new FactionUIManager();

            // Инициализация HUD и добавление кнопок
            _interactionMenu = new InteractionMenuUI();
            _interactionMenu.FactionButton.OnPressed += _ => OpenFactionMenu();

            IoCManager.Resolve<IUserInterfaceManager>().StateRoot.AddChild(_interactionMenu);
        }

        private void OpenFactionMenu()
        {
            // Заглушка для тестирования с фиктивными данными
            string factionName = "House Atreides";
            string factionDescription = "A noble house of Arrakis, known for their wisdom and honor.";
            var members = new List<string>
            {
                "Duke Leto Atreides",
                "Lady Jessica",
                "Paul Atreides",
                "Duncan Idaho",
                "Gurney Halleck"
            };

            _factionUIManager?.ShowFactionUI(factionName, factionDescription, members);
        }
    }
}
