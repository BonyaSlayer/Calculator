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
        try
        {
            _a = int.Parse(a.text);
            _b = int.Parse(b.text);
            int c = _a + _b;
            answer.text = c.ToString();
        }
        catch(Exception e)
        {
            answer.text = "�������� ��� ���!";
        }
    }

    public void pressSub()
    {
        try
        {
            _a = int.Parse(a.text);
            _b = int.Parse(b.text);
            int c = _a - _b;
            answer.text = c.ToString();
        }
        catch(Exception e)
        {
            answer.text = "�������� ��� ���!";
        }
    }

    public void pressMult()
    {
        try
        {
            _a = int.Parse(a.text);
            _b = int.Parse(b.text);
            int c = _a * _b;
            answer.text = c.ToString();
        }
        catch (Exception e) 
        {
            answer.text = "�������� ��� ���!";
        }          
    }


    public void pressDiv()
    {        
        try
        {
            _a = int.Parse(a.text);
            _b = int.Parse(b.text);
            int c = _a / _b;
            answer.text = c.ToString();
        }
        catch (Exception e)
        {
            if (e is DivideByZeroException) 
            {
                answer.text = "�� ���� ������ ������!";
            }
            else
            {
                answer.text = "�������� ��� ���!";
            }
            
        }        
    }

}
