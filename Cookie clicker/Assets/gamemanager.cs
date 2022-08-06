using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public int score = 0;
    int increment = 1;

    public Text text1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void increase()
    {
        score += increment;
        text1.text = score.ToString();
    }
    public void store()
    {
        if (score > 5)
        {
            increment++;
            score -= 5;
            text1.text = score.ToString();



        }
        else
        {
            print("You don't have enough money!");
        }
    }


}
