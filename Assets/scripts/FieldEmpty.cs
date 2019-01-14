using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FieldEmpty : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    private SpriteRenderer rend;
    private Color startColor;
    private Color hoverColor = Color.grey;

    public GameObject[] players;
    public GameObject emptyField;

    private void Start ()
    {
        rend = GetComponent<SpriteRenderer>();
        startColor = GetComponent<SpriteRenderer>().color;
        rend.material.color = startColor;
    }

    private void Update()
    {
        //After creating the game table, destroy the emptyFields
        if (Stats.stateOfTheGame == 2)
        {
            Destroy(gameObject);
        }
    }

    public void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    public void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    public void OnMouseDown()
    {
        if(Stats.stateOfTheGame == 1)
        {
            CreatingTable();
        }
    }

    private void CreatingTable()
    {
        //If the counter exceeds the number of players, set the counter to the first player
        if (Stats.currentPlayer == Stats.numberOfPlayers)
        {
            Stats.currentPlayer = 0;
        }
        Instantiate(players[Stats.currentPlayer], transform.position, Quaternion.identity);
        Stats.currentPlayer++;

        //Camera is set so that it is placed on a new object
        Vector3 current = gameObject.transform.position;
        current.z = -10;    // if .z=0, the camera would be in the object
        GameObject.Find("Main Camera").transform.position = current;

        //Creating emptyfields where the player can set his Playerfields
        SpawnEmptyFields(emptyField);
        Destroy(gameObject);

        //when you use the available fields, go to second stateOfTheGame
        if (Stats.fieldsToPlay == 0)
        {
            Stats.stateOfTheGame = 2;
        }
        Stats.fieldsToPlay--;
    }

    private void SpawnEmptyFields(GameObject empty)
    {

        RaycastHit2D hit = Physics2D.Raycast(transform.position + (1.5f * Vector3.up), (0.5f * Vector2.up), 1.2f);
        if (hit.collider == null)
        {
            Instantiate(empty, new Vector2(transform.position.x, transform.position.y + (2.2f)), Quaternion.identity, null);
        }

        hit = Physics2D.Raycast(transform.position + (1.5f * Vector3.down), (0.5f * Vector2.down), 1.2f);
        if(hit.collider == null)
        {
            Instantiate(empty, new Vector2(transform.position.x, transform.position.y - (2.2f)), Quaternion.identity);
        }

        hit = Physics2D.Raycast(transform.position + (1.5f * Vector3.left), (0.5f * Vector2.down), 1.2f);
        if (hit.collider == null)
        {
            Instantiate(empty, new Vector2(transform.position.x - (2f), transform.position.y - (1.1f)), Quaternion.identity, null);
        }

        hit = Physics2D.Raycast(transform.position + (1.5f * Vector3.left), (0.5f * Vector2.up), 1.2f);
        if (hit.collider == null)
        {
            Instantiate(empty, new Vector2(transform.position.x - (2f), transform.position.y + (1.1f)), Quaternion.identity, null);
        }

        hit = Physics2D.Raycast(transform.position + (1.5f * Vector3.right), (0.5f * Vector2.down), 1.2f);
        if (hit.collider == null)
        {
            Instantiate(empty, new Vector2(transform.position.x + (2f), transform.position.y - (1.1f)), Quaternion.identity, null);
        }

        hit = Physics2D.Raycast(transform.position + (1.5f * Vector3.right), (0.5f * Vector2.up), 1.2f);
        if (hit.collider == null)
        {
            Instantiate(empty, new Vector2(transform.position.x + (2f), transform.position.y + (1.1f)), Quaternion.identity, null);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
