using UnityEngine;
using System.Collections;

/*
*agility;
*charisma;
*dexterity;
*endurance;
*intelligence;
*luck;
*strength;
*wisdom;
*/

public class BaseWarriorClass : BaseClass {

	public BaseWarriorClass()
    {
        CharacterClassName = "Warrior";
        CharacterClassDescription = "A strong and powerful hero";
        Agility = 16;
        Charisma = 13;
        Dexterity = 14;
        Endurance = 17;
        Intelligence = 8;
        Luck = 10;
        Strength = 17;
        Wisdom = 10;
        //Total : 105
    }
}
