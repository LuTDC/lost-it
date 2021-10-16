using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Night : MonoBehaviour
{
    bool colliding = false;
    public Collected collected;

    // Update is called once per frame
    void Update()
    {
        if(colliding == true){

            if(this.tag == "red_car") collected.col[0] = 1;
            if(this.tag == "green_car") collected.col[1] = 1;
            if(this.tag == "history") collected.col[2] = 1;
            if(this.tag == "biology") collected.col[3] = 1;
            if(this.tag == "blue_jacket") collected.col[4] = 1;
            if(this.tag == "10d") collected.col[5] = 1;
            if(this.tag == "100d") collected.col[6] = 1;
            if(this.tag == "rose") collected.col[7] = 1;

            Destroy(this.gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player") colliding = true;
    }

    public void OnTriggerExit2D(Collider2D other){
        if(other.tag == "Player") colliding = false;
    }
}
