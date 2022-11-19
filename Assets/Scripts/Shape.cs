using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    public TextMeshProUGUI shapeText;

    public Rigidbody rb;

    // Encapsulation
    protected string shapeType { get; set; }
    protected Material shapeMaterial { get; set; }
    protected Color shapeColor { get; set; }
    protected string colorName { get; set; }

    private float jumpForce = 5f;

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
        shapeText.color = shapeColor;
        Jump();
    }

    // Polymorphism
    public virtual string DisplayText()
    {
        string shapeText = "Shape clicked";
        return shapeText;
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
