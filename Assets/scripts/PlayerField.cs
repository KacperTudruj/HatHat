using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerField : MonoBehaviour
{
    private int pointsNumber = 1;
    public Text pointsText;

    private void Start()
    {
        pointsText.text = pointsNumber.ToString();
        CreateText(transform.position);
    }

    private void Update()
    {
        //Write "if{}" a script with earning points
    }

    public void CreateText(Vector3 position)
    {
        Instantiate(pointsText, position, Quaternion.identity);
    }
}
