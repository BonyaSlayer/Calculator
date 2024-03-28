using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Text counter;
    int a = 0;
    
    
    
    public void onPress()
    {
        //Debug.Log(++a);
        counter.text = (++a).ToString();
    }
}
