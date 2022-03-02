using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private AudioSource deathSound;
    [SerializeField] private ParticleSystem deathEffect;

    private Animator animator;
    private Rigidbody2D rb;
    private PlayerMovement pm;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator= gameObject.GetComponent<Animator>();
        pm=gameObject.GetComponent<PlayerMovement>();
        
    }
    private void OnCollisionEnter2D(Collision2D collision2D){
        if(collision2D.gameObject.CompareTag("Obstacle")){
            Instantiate(deathEffect,transform.position,Quaternion.identity);
            deathSound.Play();
            animator.SetTrigger("Death");
            rb.bodyType=RigidbodyType2D.Static;
            pm.enabled=false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision2D){
        if(collision2D.gameObject.CompareTag("Obstacle")){
            Instantiate(deathEffect,transform.position,Quaternion.identity);
            deathSound.Play();
            animator.SetTrigger("Death");
            rb.bodyType=RigidbodyType2D.Static;
            pm.enabled=false;
        }
    }

    private void Restrart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    
}
