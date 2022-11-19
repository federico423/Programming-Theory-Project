using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    public TextMeshProUGUI shapeText;
    public TextMeshProUGUI playerNameText;

    public Rigidbody rb;

    // ENCAPSULATION
    protected string shapeType { get; set; }
    protected Material shapeMaterial { get; set; }
    protected Color shapeColor { get; set; }
    protected string colorName { get; set; }


    private float jumpForce = 5f;

    void Update()
    {
        // ABSTRACTION
        PrintName();
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked");
        shapeText.SetText(DisplayText());
        shapeText.color = shapeColor;
        Jump();
    }

    // POLYMORPHISM
    public virtual string DisplayText()
    {
        string shapeText = "Shape clicked";
        return shapeText;
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    // ABSTRACTION
    private void PrintName()
    {
        playerNameText.text = "Player: " + PlayerInfo.instance.playerName;
    }
}
