using UnityEngine;
using System.Collections;

public class CreateNewPlayer : MonoBehaviour {

    private bool isWarrior;
    private bool isMage;
    private BasePlayer newPlayer;

    private string playerName = "Name";

    void Start()
    {
        newPlayer = new BasePlayer();
    }

    /*void OnGUI()
    {
        isMage = GUILayout.Toggle(isMage, "Mage Class");
        isWarrior = GUILayout.Toggle(isWarrior, "Warrior Class");
        if (GUILayout.Button("Create"))
        {
            if (isMage)
            {
                newPlayer.playerClass = new BaseMageClass();
            }
            else if(isWarrior)
            {
                newPlayer.playerClass = new BaseWarriorClass();
            }
            newPlayer.PlayerLevel = 1;
            newPlayer.Agility = newPlayer.PlayerClass.Agility;
            newPlayer.Charisma = newPlayer.PlayerClass.Charisma;
            newPlayer.Dexterity = newPlayer.PlayerClass.Dexterity;
            newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
            newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence;
            newPlayer.Luck = newPlayer.PlayerClass.Luck;
            newPlayer.Strength = newPlayer.PlayerClass.Strength;
            newPlayer.Wisdom = newPlayer.PlayerClass.Wisdom;

            Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
            Debug.Log("Player Wisdom: " + newPlayer.PlayerClass.Wisdom);
        }
    }*/

}
