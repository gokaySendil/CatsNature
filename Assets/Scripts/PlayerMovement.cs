using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private AudioSource jumpSoundEffect;

    private enum MovementState{
        idle,running,jumping,falling
    }
    private bool isGrounded;
    float dirx=0;
    private float speed=7f;
    private float jump=30f;
    [SerializeField] private LayerMask jumpGround;
    private Rigidbody2D rb;
    private Animator anim;
    private BoxCollider2D groundChecker;
    private SpriteRenderer srenderer;
    // Start is called before the first frame update
    void Start()
    {
        srenderer=gameObject.GetComponent<SpriteRenderer>();
        anim=gameObject.GetComponent<Animator>();
        rb= gameObject.GetComponent<Rigidbody2D>();
        groundChecker= gameObject.GetComponent<BoxCollider2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if(!PauseManager.Instance.getPaused()){
            hor_Movement();
            ver_Movement();
        }
        
        
    }

    public void hor_Movement(){
        dirx = Input.GetAxisRaw("Horizontal");
        rb.velocity= new Vector2(dirx*speed,rb.velocity.y);
        UpdateAnimationState();
        
    }
    public void ver_Movement(){
        if(Input.GetButtonDown("Jump") && isgrounded()){
            jumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x,jump);
        }  
    }

    public void playIdle(){
         anim.SetInteger("state",0);
    }

    private void UpdateAnimationState(){
        MovementState state;
        if(dirx>0f){
            state=MovementState.running;
            srenderer.flipX=false;
        }else if(dirx<0){
             state=MovementState.running;
            srenderer.flipX=true;
        }else{
             state=MovementState.idle;
            
        }
        if(rb.velocity.y>0.1f){
            state=MovementState.jumping;
        }else if(rb.velocity.y<-0.1f){
            state=MovementState.falling;
        }
        anim.SetInteger("state",(int)state);
    }
    private bool isgrounded(){
       return Physics2D.BoxCast(groundChecker.bounds.center,groundChecker.bounds.size,0f,Vector2.down,.1f,jumpGround);
    }
}
