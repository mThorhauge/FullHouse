using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class hoverTavern : MonoBehaviour {
    public Rect windowRect = new Rect(0, 0, 0, 0);
    public bool lookingat = false;


    void Update()
    {
        OnMouseOver();
    }

    void OnMouseOver()
    {


        lookingat = true;
        OnGUI();
        //EditorWindow window = ScriptableObject.CreateInstance<hoverTavern>();
       // window.Show();
        

    }

    void OnGUI()
    {

        if (!lookingat) { return; }

        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        Rect menuRect = new Rect(screenPos.x, screenPos.y - 100, 100, 100);
        GUI.Label(menuRect, "Tavern LVL: " + gameStates.TavernLvl);

        

    }
}
