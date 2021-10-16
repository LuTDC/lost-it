using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Barraca : MonoBehaviour
{
    public Collected collected;
    int n = 0;

    void Update(){
        for(int i = 0; i < 8; i++){
            if(collected.col[i] == 1) n++;
        }

        if(n != 8) n = 0;
    }

    public void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player" && n == 8){
            SceneManager.LoadScene("DayTime"); 
        }
    }
}
