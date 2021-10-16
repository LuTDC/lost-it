using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text txt;
    public Score score;
    bool beingHeld = false;

    // Start is called before the first frame update
    void Start()
    {
        txt.text = "Score: " + score.itens + "\n\nClick anywhere to continue."; 
    }

    // Update is called once per frame
    void Update()
    {
        if(beingHeld) SceneManager.LoadScene("Menu");
    }

    private void OnMouseDown(){

        if(Input.GetMouseButtonDown(0)){
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            beingHeld = true;
        }

    }

    private void OnMouseUp(){
        beingHeld = false;
    }
}
