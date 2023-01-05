using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCards : MonoBehaviour
{
    public GameController gameController;
    //public GameObject openText;
    public bool inReach;

    // Start is called before the first frame update
    void Start()
    {
        inReach = false;
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            //openText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            //openText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (inReach && Input.GetKeyDown(KeyCode.E))
        {
            getKeyCard();
        }
    }

    void getKeyCard()
    {
        gameController.keyCards += 1;
        Destroy(transform.gameObject);
    }

}

