using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child : Parent
{
    private int m_age;
    public int age 
    {
        set {
            if (value < 0)
            {
                Debug.Log("Age should be poistite");
                m_age = 0;
            }
            else {
                m_age = value;
            }

        }

        get {
            return m_age;
        }
    }

    public override void SayHello()
    {
        Debug.Log("Hello, I am a child");
    }
}
