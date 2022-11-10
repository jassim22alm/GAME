using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }
      public void playGame()//This a function which used to swithc between scenes in the game
        {
             SceneManager.LoadScene("MainScene");//This will switch to the  Main scene
        }
           public void OnTriggerEnter(Collider other)//This a function which used to swith between scenes in the game
        {
             SceneManager.LoadScene("GameWins");//This will switch to the GameWins scene
        }
        public void QuitGame()//This Function will be used to quit the application(Game)
        {
              Application.Quit();
           Debug.Log("Game Quit");

        }


    // Update is called once per frame
    void Update()
    {
        
    }
}
