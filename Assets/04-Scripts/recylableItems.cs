using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recylableItems : MonoBehaviour
{
    public score currentScore;
    public int waste; 

    void OnTriggerEnter(Collider other){
        if (other.gameObject.GetComponent<bins>().binType == 0 && waste == 0) {
            currentScore.calculateScore(1);
        } 
        else if (other.gameObject.GetComponent<bins>().binType == 1 && waste == 0) {
            currentScore.calculateScore(-1);
        }
        else if (other.gameObject.GetComponent<bins>().binType == 2 && waste == 0) {
            currentScore.calculateScore(-1);
        }
        else if (other.gameObject.GetComponent<bins>().binType == 0 && waste == 1) {
            currentScore.calculateScore(-1);
        }
        else if (other.gameObject.GetComponent<bins>().binType == 1 && waste == 1) {
            currentScore.calculateScore(1);
        }
        else if (other.gameObject.GetComponent<bins>().binType == 2 && waste == 1) {
            currentScore.calculateScore(-1);
        }
        else if (other.gameObject.GetComponent<bins>().binType == 0 && waste == 2) {
            currentScore.calculateScore(-1);
        }
        else if (other.gameObject.GetComponent<bins>().binType == 1 && waste == 2) {
            currentScore.calculateScore(-1);
        }
        else if (other.gameObject.GetComponent<bins>().binType == 2 && waste == 2) {
            currentScore.calculateScore(1);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        currentScore = FindObjectOfType<score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
