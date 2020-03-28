using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scareful : MonoBehaviour
{

    private List<scareful> otherSacarefuls;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player")) 
        {

        }
        if (collision.gameObject.CompareTag("Other"))
        {
            otherSacarefuls.Add(collision.GetComponent<scareful>());
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Other"))
        {
            otherSacarefuls.Remove(other.gameObject.GetComponent<scareful>());
        }
    }

}
