using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovment : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;

    private float dirX = 0f;
    public float jumpForce = 10f;
    public float moveSpeed = 5f;


    private bool isGrounded;

    private int moveState = 0;

    public Text cherriesText;


    private enum MovementState{Idle, Running, Jumping,Failing};

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

  
        //dirX = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if(Input.GetKeyDown("space") && rb.velocity.y == 0){
            Debug.Log(rb.velocity.y);
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }


        MovementState state;


        
 






        
        if(dirX > 0f){
            state = MovementState.Running;
            sprite.flipX = false;
        }

        else if(dirX < 0f){
            state = MovementState.Running;
            sprite.flipX = true;
        }

        else{
          state = MovementState.Idle;
        }


        if(rb.velocity.y > 0.1f){
            state = MovementState.Jumping;
        }

        else if(rb.velocity.y < -0.1f){
            state = MovementState.Failing;
        }



        anim.SetInteger("State", (int)state);

        Debug.Log(dirX);


        float x = Input.acceleration.x;
        float y = Input.acceleration.y;
        float z = Input.acceleration.z;


        dirX = x;







    }


    public void jump(){
        if(rb.velocity.y == 0){
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
       
    }


    public void left(){
        Debug.Log("left");
        dirX = -1;
    
       
    }

    public void right(){
        Debug.Log("right");
        dirX = 1;
 
    }


   public void stand(){
        Debug.Log("stand");
        dirX = 0;
        rb.velocity = new Vector2(0f, rb.velocity.y);
       
    }







    
    // public void right(){
    //     dirX = 10f;
    //     transform.position += new Vector3(10,0,0) * moveSpeed * Time.deltaTime; 

    // }






}
