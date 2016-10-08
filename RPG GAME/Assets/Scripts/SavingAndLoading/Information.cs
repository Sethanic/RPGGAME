using UnityEngine;
using System.Collections;

public class Information : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public static string PlayerName { get; set; }
    public static int PlayerLevel { get; set; }
    public static BaseClass PlayerClass { get; set; }
    //Primary stats
    public static int Agility { get; set; }
    public static int Charisma { get; set; }
    public static int Dexterity { get; set; }
    public static int Endurance { get; set; }
    public static int Intelligence { get; set; }
    public static int Luck { get; set; }
    public static int Strength { get; set; }
    public static int Wisdom { get; set; }
    //Secondary stats
    public static int MaxHealth { get; set; }
    public static int CurrentHealth { get; set; }
    public static int MaxArmour { get; set; }
    public static int CurrentArmour { get; set; }
}
