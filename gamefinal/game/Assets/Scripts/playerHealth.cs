using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerHealth : MonoBehaviour
{
    public float playerHealt=100f;//Player health variable
    public Text text; //player health text
   
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text="Health : "+playerHealt;//This Statement update the Player health text 
    }
    void OnCollisionEnter(Collision obj)//function which detect the enemy
    {
             if(obj.gameObject.tag=="Enemy")//This Statement will find the object with tag of enemy
              playerHealt=playerHealt-10f;//Decrease the player health by 10
    }
}
