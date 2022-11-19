using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        shapeType = "Sphere";
        shapeMaterial = GetComponent<Material>();
        shapeColor = new Color32(0, 16, 147, 255);
        colorName = "Blue";
    }

    // POLYMORPHISM
    public override string DisplayText()
    {
        string shapeText = "You clicked a " + colorName + " " + shapeType;
        return shapeText;
    }
}
