using System.Collections.Generic;
using Content.Client.UI.Factions;
using Content.Shared.Factions;
using Robust.Client.GameObjects;
using Robust.Shared.GameObjects;

namespace Content.Client.Systems
{
    public sealed class FactionUIManager
    {
        private FactionUI? _factionUI;

        public void ShowFactionUI(string factionName, string factionDescription, List<string> members)
        {
            if (_factionUI == null || _factionUI.Disposed)
            {
                _factionUI = new FactionUI();
            }

            _factionUI.UpdateFactionInfo(factionName, factionDescription, members);
            _factionUI.OpenCentered();
        }
    }
}
