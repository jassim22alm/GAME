using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{

    public CharacterController controller;//This is a reference variable for our character controller which drive our player
    public float speed=12f; //Speed variable to control the speed of our character
    public float gravity=-9.81f;//Default value of gravity
    Vector3 velocity;//to store the value Gravitaional velocity to apply gravity on the player
     
    public Transform groundCheck;//To save the ground the check value to get red of the velocity rising in the y direction
     public float graoundDistance=0.4f;//to the how far it will check the ground and stop rising velocity in the y direction
     public LayerMask groundMask;//used to What object should the player check for
     
     public float jumpHeight=3f;//this is the height of the player jump
     bool isGrounded;//to check is the player grounded or not
   
    // Update is called once per frame
    void Update()
    {
        isGrounded=Physics.CheckSphere(groundCheck.position,graoundDistance,groundMask) ; //this will create a sphere based on ground check
       
        if(isGrounded && velocity.y<0)//This will check the groundcheck and velocity less than zero
        {
            velocity.y=-2f;
        }
    
        
        float x=Input.GetAxis("Horizontal") ; //x variable to get input  movement in horizontal directional of float datatype
        float z=Input.GetAxis("Vertical") ; //z variable to get input  movement in vertical directional of float datatype
        Vector3 move=transform.right*x+transform.forward*z;//to move the player in the direction in which he faces
          controller.Move(move*speed*Time.deltaTime);//This a function in character controller of vector3 with a motion
            
             if(Input.GetButtonDown("Jump") && isGrounded)//This condition used When the user press the space key the player will jump if he grounded
        {
            velocity.y=Mathf.Sqrt(jumpHeight*-2f*gravity);//this is a math function according to the physics formula
        }
        velocity.y+=gravity*Time.deltaTime;//increase the velocity in up and down direction
        controller.Move(velocity*Time.deltaTime);//to add the velocity to our player
    }
}
