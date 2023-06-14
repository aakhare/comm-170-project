using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm : MonoBehaviour
{
    public static bgm music;
    // Start is called before the first frame update
    
     void Awake(){
        if (music != this && music != null){
            Destroy(gameObject);
            return;
        }

        music = this;
        DontDestroyOnLoad(this.gameObject);
        return;

    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
