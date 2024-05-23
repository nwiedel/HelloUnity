using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    [Range(1, 6)]
    public int groesse = 4;
    public bool isActive = false;
    public string characterName = "Nick";
    public Vector3 punktImRaum = new Vector3(0, 0, 0);
    [SerializeField]
    private float laenge = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hallo Unity!");
    }

    // Zeichenmethode für IM-GUI-System
    private void OnGUI()
    {
        GUI.BeginGroup(new Rect(10, 10, 500, 500));

        GUI.skin.label.fontSize = 20;
        GUI.color = Color.magenta;
        // GUI.Label(new Rect(8, 5, 50, 30), characterName);
        GUILayout.BeginHorizontal();
            GUILayout.Label(characterName);
            GUI.color = Color.white;
            if(GUILayout.Button("Drück mich!"))
            {
                Debug.Log("Button wurde gedrückt!");
            }
        GUILayout.EndHorizontal();

        GUI.EndGroup();
    }

}
