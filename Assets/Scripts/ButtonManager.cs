using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour
{
    [SerializeField]private GameObject title;
    [SerializeField]private GameObject play_panel;
    [SerializeField] private GameObject play_button;
    [SerializeField]private GameObject controls_panel;
    [SerializeField] private GameObject controls_button;
    [SerializeField]private GameObject credits_panel;
    [SerializeField] private GameObject credits_button;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void open_panel(int i ){
        if(i ==1){
            play_panel.SetActive(true);
            disable_buttons();
        }else if(i==2){
            controls_panel.SetActive(true);
            disable_buttons();
        }else{
            credits_panel.SetActive(true);
            disable_buttons();
        }
    }
    public void close_panel(int i){
        if(i ==1){
            play_panel.SetActive(false);
            enable_buttons();
        }else if(i==2){
            controls_panel.SetActive(false);
             enable_buttons();
        }else{
            credits_panel.SetActive(false);
             enable_buttons();
        }

    }
    public void open_scene(int i){
         SceneManager.LoadScene(SceneUtility.GetScenePathByBuildIndex(i));
         
    }
    public void disable_buttons(){
        title.SetActive(false);
        play_button.SetActive(false);
        controls_button.SetActive(false);
        credits_button.SetActive(false);
    }
    public void enable_buttons(){
        title.SetActive(true);
        play_button.SetActive(true);
        controls_button.SetActive(true);
        credits_button.SetActive(true);
    }

    public void CloseGame(){
        Application.Quit();
    }
}
