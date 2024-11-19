public class Faction
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<string> Goals { get; set; }
    public int Resources { get; set; }
    public FactionLeader Leader { get; set; }
    public List<FactionMember> Members { get; set; }

    public Faction(string name, string description, List<string> goals, int resources, FactionLeader leader)
    {
        Name = name;
        Description = description;
        Goals = goals;
        Resources = resources;
        Leader = leader;
        Members = new List<FactionMember>();
    }

    public void AddMember(FactionMember member)
    {
        Members.Add(member);
    }

    public void RemoveMember(FactionMember member)
    {
        Members.Remove(member);
    }
}
