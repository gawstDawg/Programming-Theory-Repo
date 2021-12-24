using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Try(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Try()
    {
        Parent pt = new Parent();
        pt.SayHello();

        Child cd = new Child();
        cd.SayHello();

        cd.age = -20;
    }
}
