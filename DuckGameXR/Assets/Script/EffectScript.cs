using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectScript : MonoBehaviour
{
    public Vector3 startPos, endPos; //start and end locations for the effect to move
    public Vector4 startCol, endCol; //start and end colors for the effect to fade out - start = (1, 1, 1, 1) ; end = (1, 1, 1, 0)
    public bool isPressed;  //bool to check if condition has been met for effect to play
    public float timer, spd;
    public bool triggerPress;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isPressed) //function is only called when 
        {
            Debug.Log("effectgoing");
            EffectFunction();
        }
        else
        {
            transform.position = startPos;
            if(triggerPress) //change this conditional for whenever you want the effect to appear
            {
                isPressed = true;
                triggerPress = false;
            }
        }
    }

    private void EffectFunction()
    {
        if(GetComponent<RectTransform>().localPosition.y < endPos.y - 1)
        {
            timer += Time.deltaTime;
            GetComponent<RectTransform>().localPosition = Vector3.Lerp(startPos, endPos,timer/spd); 
            GetComponent<Image>().color = Vector4.Lerp(startCol, endCol, timer/spd);
        }
        else //once both conditions arent met, anymore, it will reset for the next time the condition is met
        {
            timer = 0;
            GetComponent<RectTransform>().localPosition = startPos;
            isPressed = false;
        }
    }
}
