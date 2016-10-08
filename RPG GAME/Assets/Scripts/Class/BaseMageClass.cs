using UnityEngine;
using System.Collections;

/*
*agility;
*charisma;
*dexterity;
*endurance;
*intelligence;
*luck;
*subtlety;
*wisdom;
*/

public class BaseMageClass : BaseClass {

	public BaseMageClass()
    {
        CharacterClassName = "Mage";
        CharacterClassDescription = "A magical wizard";
        Agility = 13;
        Charisma = 14;
        Dexterity = 16;
        Endurance = 11;
        Intelligence = 15;
        Luck = 10;
        Strength = 9;
        Wisdom = 17;
        //Total : 105
    }
}
