using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private float playerVelocity = 7f;
    [SerializeField]private float rotateVelocity = 10f;
    private void Update(){
        Vector2 new_input = new Vector2(0,0);

        if(Input.GetKey(KeyCode.Z)){
            new_input.y = 1f;
        }
        if(Input.GetKey(KeyCode.S)){
            new_input.y = -1f;            
        }
        if(Input.GetKey(KeyCode.Q)){
            new_input.x = -1f;            
        }
        if(Input.GetKey(KeyCode.D)){
            new_input.x = 1f;            
        }
        //move the player
        new_input = new_input.normalized ;
        Vector3 moveDirection = new Vector3(new_input.x, 0,new_input.y);
        transform.position += moveDirection * playerVelocity * Time.deltaTime;

        //rotate the player
        transform.forward = Vector3.Slerp(transform.forward, moveDirection, rotateVelocity * Time.deltaTime);
    }
}
