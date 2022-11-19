using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inheritance
public class Sphere : Shape
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
        string shapeText = "Sphere clicked";
        return shapeText;
    }
}
