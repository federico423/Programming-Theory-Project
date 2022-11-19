using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        shapeType = "Cube";
        shapeMaterial = GetComponent<Material>();
        shapeColor = new Color32(166, 0, 0, 255);
        colorName = "Red";
    }

    // POLYMORPHISM
    public override string DisplayText()
    {
        string shapeText = "You clicked a " + colorName + " " + shapeType;
        return shapeText;
    }
}
