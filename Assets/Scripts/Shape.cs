using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    public TextMeshProUGUI shapeText;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked");
        shapeText.SetText(DisplayText());
    }

    // Polymorphism
    public virtual string DisplayText()
    {
        string shapeText = "Shape clicked";
        return shapeText;
    }

    void Jump()
    {

    }

    void Rotate()
    {

    }
}
