using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    // Update is called once per frame
    private bool move = false;
    public Rigidbody2D rb;
    private bool isGrounded = false;
    public float speed = 20f;
    public float rotationSpeed = 2f;

    void Update(){
        if(Input.GetButtonDown("Fire1")){
            move = true;
        }
        
        if (Input.GetButtonUp("Fire1")){
            move = false;
        }
    }
    
    private void FixedUpdate(){
        if (move == true) {

            if (isGrounded) {
                rb.AddForce ( transform.right * speed * Time.fixedDeltaTime * 100f , ForceMode2D.Force);
            } else {
                rb.AddTorque (rotationSpeed * rotationSpeed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
            }
        }
        if(rb.position.y<-20f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }


    private void OnCollisionEnter2D(){
        isGrounded = true;
    }

    private void OnCollisionExit2D(){
        isGrounded = false;
        
    }
}
