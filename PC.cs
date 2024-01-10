/////////////////////////////////////////////////
///PC (short for player character) describes a member of a DND party.
///Ultimate purpose is to demonstrate LINQ!
///Idea inspired by J.Battista, 2019
///This version written by M.Bell for 2024
/////////////////////////////////////////////////
///

class PC {
    //PCs have an actual player playing them
    public Player Owner {get; init;}

    //PCs have a name and a race
    public string Name {get; init;}
    public string Race {get; init;}

    //PCs can multiclass
    public List<ClassLvl> classLvls = new List<ClassLvl>();

    //Hint: Classes can be turned into a long string!
    //public string Classes {
    //    get {
            //How would you write this?
    //    }
    //}

    public PC(Player p, string name="Epic Hero", string race="Human", string ClassN="Wimp") {
        Owner = p;
        Name = name;
        Race = race;
        classLvls.Add(new ClassLvl(ClassN));
    }

    public override string ToString()
    {
        string id = Name + " is a " + Race + " played by " + Owner.ToString();
        return id;
    }
}