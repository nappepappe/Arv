﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usable : Item
{
    public  float uses;
    public float maxUses = 5;
    public void OnMouseUpAsButton()
    {
        
    }
    public virtual void Use()
    {

    }
    /*public virtual string UseText()
    {

    }
    public string NoUsesLeft()
    {

    }*/

    public override string ToString()
    {
        return base.ToString();
    }
}
