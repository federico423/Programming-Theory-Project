using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inheritance
public class Cube : Shape
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // Polymorphism
    public override string DisplayText()
    {
        string shapeText = "Cube clicked";
        return shapeText;
    }
}
