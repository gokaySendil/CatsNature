using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShowUp : MonoBehaviour
{


    [SerializeField] TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision2D){
        if(collision2D.gameObject.CompareTag("Player") ){
            text.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D  collision2D){
        if(collision2D.gameObject.CompareTag("Player") ){
            text.gameObject.SetActive(false);
        }
    }
}
