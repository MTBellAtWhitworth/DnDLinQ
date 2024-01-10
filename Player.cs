//////////////////////////////////////////////////
/////////////////////////////////////////////////

using System.ComponentModel.DataAnnotations;

///A player class for keeping track of real world
///D&D players. Serves the TeamMember class.
///Written by M.Bell for 2024
///
class Player {

    //Players have names
    public string? FName {get; set;}
    public string? LName {get; set;}

    //Players have contact info
    public string? EMail {get; set;}
    public string? Phone {get; set;}

    public Player(string fname="Joe", string lname="Player", string email="jp@dnd.com", string phone="") {
        FName = fname;
        LName = lname;
        EMail = email;
        Phone = phone;
    }

    public override string ToString()
    {
        return FName + " " + LName;
    }
}