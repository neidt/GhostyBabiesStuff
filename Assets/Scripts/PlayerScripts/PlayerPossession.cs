using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPossession : MonoBehaviour
{
    public GameObject parentObj;
    private GameObject childObj;
    public bool isPossessing = false;
    private bool somethingInRange;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isPossessing && somethingInRange)
        {
            Possess(this.gameObject, childObj);
        }
        else
        {
            DePossess(childObj);
        }
    }


    public void Possess(GameObject parent, GameObject child)
    {
        isPossessing = true;
        //sets parent and child
        child.transform.SetParent(parent.transform);

        //calls getinfo and disable child
        GetInfo(parent, child);
        DisableChild(child);
    }

    public void DePossess(GameObject child)
    {
        //unparents child
        isPossessing = false;
        child.GetComponent<SpriteRenderer>().enabled = true;
        child.transform.SetParent(null);
    }

    public void GetInfo(GameObject parent, GameObject child)
    {
        //passes up info into the scripts???
        //????
    }
    
    public void DisableChild(GameObject child)
    {
        //disables child object
        child.GetComponent<SpriteRenderer>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Adult"))
        {
            somethingInRange = true;
            childObj = other.gameObject;
        }
    }
}
