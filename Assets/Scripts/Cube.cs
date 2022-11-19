using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inheritance
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
