using UnityEngine;
using System.Collections;

public class BaseClass : MonoBehaviour {

    private string characterClassName;
    private string characterClassDescription;

    private int agility;
    private int charisma;
    private int dexterity;
    private int endurance;
    private int intelligence;
    private int luck;
    private int strength;
    private int wisdom;

    public string CharacterClassName
    {
        get { return characterClassName; }
        set { characterClassName = value; }
    }

    public string CharacterClassDescription
    {
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }

    public int Agility
    {
        get { return agility; }
        set { agility = value; }
    }

    public int Charisma
    {
        get { return charisma; }
        set { charisma = value; }
    }

    public int Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }

    public int Endurance
    {
        get { return endurance; }
        set { endurance = value; }
    }

    public int Intelligence
    {
        get { return intelligence; }
        set { intelligence = value; }
    }

    public int Luck
    {
        get { return luck; }
        set { luck = value; }
    }

    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    public int Wisdom
    {
        get { return wisdom; }
        set { wisdom = value; }
    }
}
