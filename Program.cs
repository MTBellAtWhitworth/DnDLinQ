﻿////////////////////////////////////////////////////////
///A series of LINQ queries for illustrating their power
///on a collection of D&D players in a campaign!
///Written by M.Bell, 2024 and inspired by J.Battista, 2019
////////////////////////////////////////////////////////
///

//First make the players
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
Console.WriteLine("And now getting rangers");
var rangerPCs = from r in myCampaign
                where r.Classes.Contains("Ranger")
                select r;
foreach(var ranger in rangerPCs) {
    Console.WriteLine(ranger.ToString());
}
