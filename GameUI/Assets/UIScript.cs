using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text HealthText;
    int Health = 10;
    int width;
    int height;

    public void SetWidth(int newW)
    {
        width = newW;
    }

    public void SetHeight(int newH)
    {
        height = newH;
    }

    public void SetRes()
    {
        Screen.SetResolution(width,height,false);
        Debug.Log( "Res changed to " + width + "x" + height);
    }
    void Update()

    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Health--;
        }

        HealthText.text = "Health:" + Health;
    }


}
