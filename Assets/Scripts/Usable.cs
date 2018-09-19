using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usable : Item
{
    public  float uses;
    public float maxUses = 5;
    public void OnMouseUpAsButton()
    {
        Use();
    }
    public virtual void Use()
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
    public virtual string UseText()
    {
        return "Consumed " + foodname + ", it was tasty.";
    }
    public string NoUsesLeft()
    {
        return "You have no more " + foodname;
    }

    public override string ToString()
    {
        return "Food Name: " + foodname + ". Cost " + cost.ToString() + ". Weight " + weight.ToString() + ". Cost Per Kg " + GetCostPerKilo().ToString() + ". Uses left: " + uses + "/" + maxUses;
    }
}
