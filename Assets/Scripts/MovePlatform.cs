using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    [SerializeField]private GameObject[] points;
    private int point_index=0;
    private float speed =2.3f;
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(points[point_index].transform.position,transform.position)<.1f){
            point_index++;
            if(point_index>= points.Length){
                point_index=0;
            }
        }
        transform.position=Vector2.MoveTowards(transform.position,points[point_index].transform.position,Time.deltaTime*speed);
        
    }
}
