using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FieldEmpty : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{

    //public Color hoverColor;

    //private SpriteRenderer spriteRenderer;
    //private Color startColor;

    public GameObject[] players;
    public GameObject emptyField;

    void Start ()
    {
        // wrote function who check the player numer 
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //startColor = spriteRenderer.color;
        //startColor = spriteRenderer.color;
    }

    public void OnMouseEnter()
    {
        //GetComponent<Renderer>().material.color = hoverColor;
        //spriteRenderer.material.color = hoverColor;
    }

    public void OnMouseDown()
    {
        //if (!(currentPlayer == numberOfPlayer))
        //{
        //    if (currentPlayer == 3)
        //    {
        //        Instantiate(players[currentPlayer], transform.position, Quaternion.identity);
        //        currentPlayer++;
        //    }
        //    if (currentPlayer == 2)
        //    {
        //        Instantiate(players[currentPlayer], transform.position, Quaternion.identity);
        //        currentPlayer++;
        //    }
        //    if (currentPlayer == 1)
        //    {
        //        Instantiate(players[currentPlayer], transform.position, Quaternion.identity);
        //        currentPlayer++;
        //    }
        //    if (currentPlayer == 0)
        //    {
        //        Instantiate(players[currentPlayer], transform.position, Quaternion.identity);
        //        currentPlayer++;
        //    }
        //}
        //else
        //{
        //    currentPlayer = 0;
        //}
        Debug.Log("Przed: " +  Stats.currentPlayer);
        if (Stats.currentPlayer == Stats.numberOfPlayer)
        {
            Stats.currentPlayer = 0;
            Debug.Log("I am in :3 " + Stats.currentPlayer);
        }
        Debug.Log("Po: " + Stats.currentPlayer);
        Instantiate(players[Stats.currentPlayer], transform.position, Quaternion.identity);
        Stats.currentPlayer++;
        Debug.Log("Po0: " + Stats.currentPlayer);

        //Instantiate(players[1], transform.position, Quaternion.identity);
        SpawnEmptyFields(emptyField);
        Destroy(gameObject);
    }

    public void OnMouseExit()
    {
       //spriteRenderer.material.color = startColor;
    }


    void Update () {
		
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
            Instantiate(empty, new Vector2(transform.position.x - (2f), transform.position.y - (1.1f)), Quaternion.identity);
        }

        hit = Physics2D.Raycast(transform.position + (1.5f * Vector3.left), (0.5f * Vector2.up), 1.2f);
        if (hit.collider == null)
        {
            Instantiate(empty, new Vector2(transform.position.x - (2f), transform.position.y + (1.1f)), Quaternion.identity);
        }

        hit = Physics2D.Raycast(transform.position + (1.5f * Vector3.right), (0.5f * Vector2.down), 1.2f);
        if (hit.collider == null)
        {
            Instantiate(empty, new Vector2(transform.position.x + (2f), transform.position.y - (1.1f)), Quaternion.identity);
        }

        hit = Physics2D.Raycast(transform.position + (1.5f * Vector3.right), (0.5f * Vector2.up), 1.2f);
        if (hit.collider == null)
        {
            Instantiate(empty, new Vector2(transform.position.x + (2f), transform.position.y + (1.1f)), Quaternion.identity);
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
