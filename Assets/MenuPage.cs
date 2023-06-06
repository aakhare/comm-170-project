using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPage : MonoBehaviour
{
    public void QuitButton(){
        Application.Quit();
        Debug.Log("Game Closed");

    }

    public void PlayButton(){
       // SceneManager.LoadScene("Trash Test");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
