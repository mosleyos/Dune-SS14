[RegisterSystem]
public class FactionSystem : EntitySystem
{
    private FactionManager _factionManager;

    public override void Initialize()
    {
        base.Initialize();
        _factionManager = IoCManager.Resolve<FactionManager>();
    }

    public void AssignPlayerToFaction(EntityUid player, string factionId)
    {
        var faction = _factionManager.GetFaction(factionId);
        if (faction == null)
        {
            Logger.Error($"Faction with ID {factionId} not found!");
            return;
        }

        var factionComponent = EntityManager.GetComponent<FactionComponent>(player);
        factionComponent.SetFaction(faction, new FactionMember { Role = "Soldier" });
    }
}
