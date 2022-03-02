using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collector : MonoBehaviour
{

    [SerializeField] private Collider2D playerCollider;
    [SerializeField] private AudioSource collect;
    [SerializeField] private ParticleSystem collectEffect;

    private int collectable_count_in_level;
    void Start(){
        collectable_count=0;
        collectable_count_in_level = GameObject.FindGameObjectsWithTag("Collectable").Length;
        text.text="Collected => "+collectable_count+"-"+collectable_count_in_level;

    }

   [SerializeField] private TMP_Text text;
    private int collectable_count =0;
   private void OnTriggerEnter2D(Collider2D collider){
       if(collider.gameObject.CompareTag("Collectable") && playerCollider.IsTouching(collider)){
           Instantiate(collectEffect,transform.position,Quaternion.identity);
           Destroy(collider.gameObject);
           collect.Play();
           collectable_count++;
           text.text="Collected => "+collectable_count+"-"+collectable_count_in_level;
       }
   }
   public int getCollectedCount(){
       return collectable_count;
   }
   public int getTotalCoin(){
       return collectable_count_in_level;
   }
}
