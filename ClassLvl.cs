////////////////////////////////////////////////////
///Under D&D rules, PCs can take multiple classes
///and then advance in them at different rates.
///Written by M.Bell for 2024
////////////////////////////////////////////////////
///

class ClassLvl {
    //Classes have a class and a level in that class
    public string Class {get; init;}
    public int Level {get; set;}

    //You always start at level 1. So many ways to improve this!
    public ClassLvl(string classname="Meatshield", int lvl=1) {
        Class = classname;
        Level = lvl;
    }
}