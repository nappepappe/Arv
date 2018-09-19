using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Usable
{
    public bool isYummy;
    public float saturation;
    public override void Use()
    {
        if (uses < maxUses)
        {
            Debug.Log(UseText());
            uses++;
        }
        else
        {
            NoUsesLeft();
        }
    }
    public override string UseText()
    {
         return "Consumed " + foodname + ". " + YummyToString();
    }
    public override string ToString()
    {
        return base.ToString();
    }
    public string YummyToString()
    {
        if (isYummy)
        {
            return " It was tasty.";
        }
        else
        {
            return "It was not tasty.";
        }
    }
}
