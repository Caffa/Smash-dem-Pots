using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScore : MonoBehaviour
{

    public static int Score = 0;
    // public static int HP = 150;
    public static int EXP = 0;
    public static int Level = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI(){
        GUI.Box(new Rect(0,0,75,20), "Score : " + Score.ToString());
        // GUI.Box(new Rect(0,20,80,20), "HP : " + HP.ToString());
        GUI.Box(new Rect(0,20,115,20), "Food for Shuu : " + EXP.ToString());
        
        

        if(KeepScore.EXP > 100){
                GUI.Box(new Rect(100, 100, 200, 20), "Level Up!");
                KeepScore.EXP -= 100;
                KeepScore.Level += 1;
        }

        if(KeepScore.Level > 0){
            GUI.Box(new Rect(0,40,100,20), "Shuu's <3 : " + Level.ToString());
        }

        // if(KeepScore.HP <= 90)
               
        //      GUI.Box(new Rect(100,100,200,20), "Watch Out! LOW HP!");
    }
}
