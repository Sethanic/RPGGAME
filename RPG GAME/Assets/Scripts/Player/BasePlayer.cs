using UnityEngine;
using System.Collections;

public class BasePlayer : MonoBehaviour {

    public string playerName;
    public int playerLevel;
    public BaseClass playerClass;

    private int agility;
    private int charisma;
    private int dexterity;
    private int endurance;
    private int intelligence;
    private int luck;
    private int strength;
    private int wisdom;

    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }

    public int PlayerLevel
    {
        get { return playerLevel; }
        set { playerLevel = value; }
    }

    public BaseClass PlayerClass
    {
        get { return playerClass; }
        set { playerClass = value; }
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
