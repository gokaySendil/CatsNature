using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public static PauseManager Instance { get; private set; }

    private bool paused;
    // Start is called before the first frame update

    void Awake(){
        if(Instance == null) {Instance=this;}
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Escape) && !paused){
            pauseMenu.SetActive(true);
            Time.timeScale=0f;
            paused=true;
            
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && paused){
            pauseMenu.SetActive(false);
            Time.timeScale=1f;
            paused=false;
        }
        
        
    }
    public bool getPaused(){
        return paused;
    }
    public void returnMenu(){
        paused=false;
        Time.timeScale=1f;
        SceneManager.LoadScene(0,LoadSceneMode.Single);
    }
    public void CloseGame(){
        Application.Quit();
    }
}
