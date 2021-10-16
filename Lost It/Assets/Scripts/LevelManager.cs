using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Collected collected;
    public GameObject[] itens = new GameObject[8];
    public GameObject[] visitantes = new GameObject[4];
    int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 8; i++){
            if(collected.col[i] == 0) Destroy(itens[i]);
        }

        for(int i = 1; i < 4; i++) visitantes[i].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void proximoVisitante(){
        index++;
        visitantes[index].SetActive(true);
        visitantes[index-1].SetActive(false);
    }
}
