using System.Collections.Generic;

[System.Serializable]

public class User
{
    public string userName;
    public long energy;
    public List<Soldier> soldierList = new List<Soldier>();
}