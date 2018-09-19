using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string foodname;
    public float weight;
    public float cost;

    public float GetCostPerKilo()
    {
        return cost / weight;
    }
    public override string ToString()
    {
        return "Food Name: " + foodname + "\nCost " + cost.ToString() + "\nWeight"+ weight.ToString() + "\nCost Per Kg " + GetCostPerKilo().ToString();
    }
    public void OnMouseEnter()
    {
        
    }
}
