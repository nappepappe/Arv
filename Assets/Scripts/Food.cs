using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Usable
{
    public bool isYummy;
    public float saturation;
    public override void Use()
    {

    }
    /*public override void UseText()
    {

    }*/
    public override string ToString()
    {
        return base.ToString();
    }
    /*public string YummyToString()
    {

    }*/
}
