using System;
using System.Collections.Generic;
//class First
//{
//    static List<string> GetWeapons (List<string> listWeapon) //Game - War Hostiles
//    {
//        listWeapon.Add("AK-47");
//        listWeapon.Add("M4A1");
//        listWeapon.Add("M16");
//        listWeapon.Add("STG-44");
//        listWeapon.Add("AWP");
//        foreach(string weapon in listWeapon)
//        {
//            Console.Write($"{weapon}; ");
//        }    
//        return listWeapon;
//    }
//    static List<string> GetPotions (List<string> ListPotions)
//    {
//        ListPotions.Add("Health");
//        ListPotions.Add("Mana");
//        ListPotions.Add("Fire Resistance");
//        ListPotions.Add("Saving ammunition");
//        ListPotions.Add("Night vision");
//        foreach (string potion in ListPotions)
//        {
//            Console.Write($"{potion}; ");
//        }
//        return ListPotions;
//    }
//    static List<string> GetResources (List<string> ListResources)
//    {
//        ListResources.Add("Material");
//        ListResources.Add("Food");
//        ListResources.Add("Drinks");
//        ListResources.Add("Building materials");
//        ListResources.Add("Armor");
//        foreach (string resource in ListResources)
//        {
//            Console.Write($"{resource}; ");
//        }
//        return ListResources;
//    }
//    static void Main()
//    {
//        Console.Write("Your Items: ");
//        string choise = Console.ReadLine();
//        List<string> items = new List<string>();
//        switch (choise)
//        {
//            case "1":
//                GetWeapons(items);
//                break;
//            case "2":
//                GetPotions(items);
//                break;
//            case "3":
//                GetResources(items);
//                break;
//            default:
//                Console.Write("E");
//                break;
//        }
//    }
//}
class Second
{
    static List<string> Normal (List<string> Item) // Granny items
    {
        Item.Add("Master Key");
        Item.Add("Padlock Key");
        Item.Add("Hummer");
        Item.Add("Cutting Wires");
        Item.Add("Code");
        foreach(string item in Item)
        {
            Console.Write($"{item}; ");
        }
        return Item;
    }
    static List<string> Easy (List<string> Item)
    {
        Item.Add("Master Key");
        Item.Add("Padlock Key");
        Item.Add("Hummer");
        Item.Add("Cutting Wires");
        Item.Add("Code");
        Item.Remove("Code");
        foreach (string item in Item)
        {
            Console.Write($"{item}; ");
        }
        return Item;
    }
    static List<string> Hard (List<string> Item)
    {
        Item.Add("Master Key");
        Item.Add("Padlock Key");
        Item.Add("Hummer");
        Item.Add("Cutting Wires");
        Item.Add("Code");
        Item.Add("Battery");
        foreach (string item in Item)
        {
            Console.Write($"{item}; ");
        }
        return Item;
    }
    static void Main()
    {
        Console.Write("Your difficulty: ");
        string choise = Console.ReadLine();
        List<string> Lock = new List<string>();
        switch (choise)
        {
            case "1":
                Normal(Lock);
                break;
            case "2":
                Easy(Lock);
                break;
            case "3":
                Hard(Lock);
                break;
            default:
                Console.Write("E");
                break;
        }
    }
}
