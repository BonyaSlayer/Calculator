using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CalcScript : MonoBehaviour
{
    public Text answer;
    public InputField a;
    public InputField b;
    private int _a;
    private int _b;

    

    public void pressSum()
    {
        _a = int.Parse(a.text);
        _b = int.Parse(b.text);
        int c = _a + _b;
        answer.text = c.ToString();
    }

    public void pressSub()
    {
        _a = int.Parse(a.text);
        _b = int.Parse(b.text);
        int c = _a - _b;
        answer.text = c.ToString();
    }

}
