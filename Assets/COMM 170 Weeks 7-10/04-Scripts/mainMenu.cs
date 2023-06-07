using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.SceneManagement.SceneManager;

public class mainMenu : MonoBehaviour
{
    public void QuitButton(){
        Application.Quit();
        Debug.Log("Game Closed");

    }

    public void PlayButton(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Instructions");
    }

    public void Continue1(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Instr2");
    }

    public void Continue2(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Instr3");
        Debug.Log("Continue2: loading Instr3");
    }

    public void Continue3(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Instr4");
    }

    public void Continue4(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("TrashTest");
    }
    
    // Start is called before the first frame update
    
  /*  void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
