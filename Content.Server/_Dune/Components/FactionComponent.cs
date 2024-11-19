[RegisterComponent]
public class FactionComponent : Component
{
    public Faction Faction { get; set; }
    public FactionMember Member { get; set; }

    public void SetFaction(Faction faction, FactionMember member)
    {
        Faction = faction;
        Member = member;
    }
}
