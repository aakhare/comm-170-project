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
