using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    
    private Rigidbody2D rb;
    private PlayerMovement pm;
    [SerializeField] private AudioSource completeSound;
    [SerializeField] private GameObject completePanel;
    [SerializeField] private GameObject exit;
    [SerializeField] private ParticleSystem effect;

    

    void Start()
    {
        //effect= effect.GetComponent<ParticleSystem>();
        rb= GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<Rigidbody2D>();
        pm=GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<PlayerMovement>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        
    }
    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.CompareTag("Player")){
            completeSound.Play();
            Instantiate(effect,transform.position+new Vector3(0f,1.5f,0f),Quaternion.identity);
            completePanel.SetActive(true);
            pm.playIdle();
            rb.bodyType=RigidbodyType2D.Static;
            pm.enabled=false;
            
        }
    }
}
