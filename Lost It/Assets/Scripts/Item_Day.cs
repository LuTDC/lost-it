using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Item_Day : MonoBehaviour
{
    bool beingHeld = false;
    bool isColliding = false;
    string tag;
    LevelManager lvlMng;
    public Score score;

    void Start(){
        lvlMng = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(beingHeld == true){
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            
            this.gameObject.transform.localPosition = new Vector3(mousePos.x, mousePos.y, 0);
        }
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

        if(isColliding){
            if(tag == "boy" && this.gameObject.tag == "red_car") score.itens++;
            else if(tag == "girl" && this.gameObject.tag == "history") score.itens++;
            else if(tag == "mother" && this.gameObject.tag == "10d") score.itens++;
            else if(tag == "man" && this.gameObject.tag == "rose") score.itens++;
            
            if(tag != "man") lvlMng.proximoVisitante();
            else SceneManager.LoadScene("Final");

            isColliding = false;
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        isColliding = true;
        tag = other.tag;
    }

    void OnTriggerExit2D(Collider2D other){
        isColliding = false;
        tag = "";
    }
}
