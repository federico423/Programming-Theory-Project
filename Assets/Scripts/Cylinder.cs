using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cylinder : Shape
{
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        shapeType = "Cylinder";
        shapeMaterial = GetComponent<Material>();
        shapeColor = new Color32(0, 94, 7, 255);
        colorName = "Green";
    }

    // POLYMORPHISM
    public override string DisplayText()
    {
        string shapeText = "You clicked a " + colorName + " " + shapeType;
        return shapeText;
    }
}
