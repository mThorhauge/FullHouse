using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class hoverTavern : MonoBehaviour {

	void OnMouseOver()
    {


        ONGUI();

        


    }

    void ONGUI()
    {
        
        EditorGUILayout.Label("LVL:" + gameStates.TavernLvl, EditorStyles.wordWrappedLabel);

        EditorWindow window = EditorWindow.CreateInstance<EditorWindowWithPopup>();
        window.Show();

    }
}
