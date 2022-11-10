using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
          public void OnTriggerEnter(Collider other)//This a function which used to swith between scenes in the game
        {
             SceneManager.LoadScene("GameOver");//This will switch to the GameOver scene when touch by the enemy
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
