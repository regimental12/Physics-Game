﻿using UnityEngine;
using System.Collections;

public class scoreManager : MonoBehaviour {

    public Font font;
    public int score = 0;
   
    void OnGUI()
    {        
        GUI.skin.font = font;
        GUI.color = Color.grey;
        //GUI.skin.box.fontSize = 36;
        //GUIStyle style = new GUIStyle(GUI.skin.box);
        //style.padding = new RectOffset(0, 0, 20, 0);
        
        //GUI.Box(new Rect(-25, 0, Screen.width +40, 100),  "Score: " + score /*, style*/);
        GUI.Label(new Rect(Screen.width/2 - 70, 10, Screen.width + 40, 100), "SCORE: " + score);
    }
	
}
