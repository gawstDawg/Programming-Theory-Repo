using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour
{
    public virtual void SayHello()
    {
        Debug.Log("Hello, I am a Parent");
    }
}
