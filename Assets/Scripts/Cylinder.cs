using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inheritance
public class Cylinder : Shape
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
        string shapeText = "Cylinder clicked";
        return shapeText;
    }
}
