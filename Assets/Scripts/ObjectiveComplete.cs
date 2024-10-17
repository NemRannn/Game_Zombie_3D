using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveComplete : MonoBehaviour
{
    [Header("Objectives to Complete")]
    public Text objective1;
    public Text objective2;
    public Text objective3;
    public Text objective4;

    public static ObjectiveComplete occurence;

    private void Awake()
    {
        occurence = this;
    }
    
    public void GetObjectivesDone(bool obj1, bool obj2, bool obj3, bool obj4)
    {
        if(obj1 == true)
        {
            objective1.text = "01. Completed";
            objective1.color = Color.green;

        }
        else
        {
            objective1.text = "01. FIND THE RIFLE";
            objective1.color = Color.white;
        }

        if (obj2 == true)
        {
            objective2.text = "02. Completed";
            objective2.color = Color.green;
        }
        else
        {
            objective2.text = "02. FIND THE VILLAGER";
            objective2.color = Color.white;
        }

        if (obj3 == true)
        {
            objective3.text = "03. Completed";
            objective3.color = Color.green;
        }
        else
        {
            objective3.text = "03. FIND THE VEHICLE";
            objective3.color = Color.white;
        }

        if (obj4 == true)
        {
            objective4.text = "04. Completed";
            objective4.color = Color.green;
        }
        else
        {
            objective4.text = "04. TAKE ALL OF VILLAGER INTO VEHICLE";
            objective4.color = Color.white;
        }

    }
}
