using UnityEngine;
using System.Collections;

public class TestGUI : MonoBehaviour
{
    private BaseClass class1 = new BaseMageClass { };
    private BaseClass class2 = new BaseWarriorClass { };
    public TextMesh text;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnGUI()
    {
        GUILayout.Label(class1.CharacterClassName);
        GUILayout.Label(class1.CharacterClassDescription);
        GUILayout.Label(class2.CharacterClassName);
        GUILayout.Label(class2.CharacterClassDescription);
    }
}