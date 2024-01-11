////////////////////////////////////////////////////////
////////////////////////////////////////////////////////

//First make the players
using System.Runtime.CompilerServices;

///A series of LINQ queries for illustrating their power
///on a collection of D&D players in a campaign!
///Written by M.Bell, 2024 and inspired by J.Battista, 2019
///
Player matt = new Player("Matt", "Bell", "mbell@whitworth.edu", "509-777-3472");
Player chris = new Player("Chris", "", "", "");
Player sierra = new Player("Sierra", "", "", "");
Player dylan = new Player("Dylan", "", "", "");
Player colton = new Player("Colton", "", "", "");
Player amanda = new Player("Amanda", "", "", "");

//Now assign PCs!
PC pannan = new PC(matt, "Pannan Two-Souled", "Half-Elf", "Paladin of the Old Gods");
PC pershu = new PC(chris, "Persu the Empty", "Gnome", "Ranger");
PC layla = new PC(sierra, "Layla Tarabor", "Elf", "Rogue");
layla.classLvls.Add(new ClassLvl("Warlock"));
PC mousr = new PC(dylan, "Mousr", "Kenku", "Ranger");
mousr.classLvls.Add(new ClassLvl("Cleric"));
PC glovan = new PC(colton,"Glovan Fireforge", "Dwarf", "Eldritch Knight");
PC rose = new PC(amanda, "Rose", "Elf", "Druid");

//Now, put 'em all in a list!
List<PC> myCampaign = new List<PC>();
myCampaign.Add(pannan);
myCampaign.Add(pershu);
myCampaign.Add(layla);
myCampaign.Add(mousr);
myCampaign.Add(glovan);
myCampaign.Add(rose);

//Now, using LINQ, get all the elves!
Console.WriteLine("Getting the Elves");
var elvishPCs = from elf in myCampaign
                where elf.Race.Contains("Elf")
                select elf;
foreach(var elf in elvishPCs) {
    Console.WriteLine(elf.ToString());
}

//Now it's your turn! Try grabbing all the rangers!
//Hint: you need to add a custom getter to class PC to retrieve all the classes
//  (try making a string)!
Console.WriteLine("And now getting rangers");
//Put your LinQ query here!

//Finally, print it out!

//Now try doing the same things as above, but using Lambda syntax. See the textbook!


//This bit just in here to test indexers. Try your hand at it!
//Use LinQ to get anyone who is multiclassed:
var MCers = from mc in myCampaign
            where mc.classLvls.Count > 1
            select mc;

foreach(var mc in MCers) {
    Console.WriteLine("My name is {0}. I am a: ", mc.Name);
    for(int i = 0; i < mc.classLvls.Count; ++i) {
        string curClass = mc[i].Class;
        int curLvl = mc[i].Level;
        Console.Write("{0} of level {1} ",
                curClass, curLvl);
    }
    Console.WriteLine(" and my race is {0}", mc.Race);
}