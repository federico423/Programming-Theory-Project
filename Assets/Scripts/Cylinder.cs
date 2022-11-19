using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inheritance
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

    void Update()
    {

    }

    // Polymorphism
    public override string DisplayText()
    {
        string shapeText = "You clicked a " + colorName + " " + shapeType;
        return shapeText;
    }
}
