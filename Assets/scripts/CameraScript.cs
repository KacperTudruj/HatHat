using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float panSpeed = 30f;
    public float panBorderThickness = 10f;
    private string buttonToMakeDistance = "space"; //soon write the funcion to set button to make Distance

	void Update ()
    {
        CameraMovmentByMouse();
        Distance(buttonToMakeDistance);
    }

    void CameraMovmentByMouse()
    {
        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            transform.Translate(Vector3.up * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            transform.Translate(Vector3.down * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        {
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }
    }

    void Distance(string buttonToPress)
    {
        if (Input.GetKeyDown(buttonToPress))
        {
            Vector3 current = gameObject.transform.position;
            if (current.z < -20)
            {
                current = gameObject.transform.position;
                current.z = 0;
            }
            current.z -= 10;
            GameObject.Find("Main Camera").transform.position = current;
        }
    }
}
