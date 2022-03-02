using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f,0.0f,1f);
        
    }
    void OnTriggerEnter2D(Collider2D collision2D){
        if(collision2D.gameObject.CompareTag("Player") || collision2D.gameObject.CompareTag("Ground")){
            Destroy(this.gameObject);
        }
    }
}
