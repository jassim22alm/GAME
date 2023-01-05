using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3Door : MonoBehaviour
{
    public Animator door;
    public GameController gameController;
    //public GameObject openText;
    public bool inReach;

    // Start is called before the first frame update
    void Start()
    {
        inReach = false;
        door = this.transform.parent.GetComponent<Animator>();
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            //penText.SetActive(true);
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
        if (inReach && gameController.keyCards == 2 && Input.GetKeyDown(KeyCode.E))
        {
            DoorOpens();
        }
    }

    void DoorOpens()
    {
        door.SetBool("character_nearby", true);
    }

}