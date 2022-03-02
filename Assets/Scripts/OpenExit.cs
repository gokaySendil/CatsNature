using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenExit : MonoBehaviour
{
    
    private Collector collector;
    [SerializeField]private GameObject exit;
    // Start is called before the first frame update
    void Start()
    {
        collector = GameObject.FindGameObjectWithTag("Player").GetComponent<Collector>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(collector.getCollectedCount()>= collector.getTotalCoin()){
            exit.SetActive(true);

        }
        
        
    }
    public void loadNextScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
