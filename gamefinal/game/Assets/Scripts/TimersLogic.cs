
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TimersLogic : MonoBehaviour
{
  
    int TimerStartValue=90;//An integer variable which holds the start value of timer
    
     public Text Timer;//Text variable to access the text of timer in the UI
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        CountDownTimer();//This is called in the start function
    }
    void CountDownTimer()//This function will perform the time countdown task
    {
        if(TimerStartValue>0)//this state will check if the time start value is greater than zero the value will print in the debug log
          {
        
        
          Timer.text="Timer : "+TimerStartValue+"s";
          TimerStartValue--;//This will decrease the time start value gradually
          Invoke("CountDownTimer",0.4f);//Invoke a method after 0.4second
    
          }
          else
          {
              SceneManager.LoadScene("GameOver");//This will switch to the game over scene
          }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
