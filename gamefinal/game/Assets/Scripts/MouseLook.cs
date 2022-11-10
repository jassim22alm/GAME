using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity=100f;//To control the mouse speed
    public Transform playerBody;
  
    float xRotation=0f;   //Float variable to save the rotation in y axis
    // Start is called before the first frame update
   
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX=Input.GetAxis("Mouse X")*mouseSensitivity*Time.deltaTime; //This is a preprogram access inside of unity which changes based on  mouse movement
        float mouseY=Input.GetAxis("Mouse Y")*mouseSensitivity*Time.deltaTime;
         
        xRotation -=mouseY;//To decrease the rotation based on mouse y
        xRotation=Mathf.Clamp(xRotation,-90f,90f);
        
      transform.localRotation=Quaternion.Euler(xRotation,0f,0f);//Quaternion is responsible for rotation in unity with Euler angle
        playerBody.Rotate(Vector3.up*mouseX);//To specify an axis to rotate around
     
    
    }
}
