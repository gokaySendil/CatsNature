using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    [SerializeField] private float destroyTime;
    // Start is called before the first frame update
    [SerializeField]private GameObject prefab;
    [SerializeField] private GameObject gun;
    [SerializeField] private Vector2 direct;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void fireShootDirection(){
        GameObject go =   Instantiate(prefab,gun.transform.position,Quaternion.identity);;
        //go.GetComponent<Rigidbody2D>().AddForce(direct*50f);
        go.GetComponent<Rigidbody2D>().velocity = direct;
        Destroy(go,destroyTime);
    }
}
