using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class draggableObject : MonoBehaviour
{
public float dragRange=3;
public Vector3 mPos;
public Vector3 thisPos;
Vector3 defaultPos;
bool dragging=false;
void Awake(){
    defaultPos=this.gameObject.transform.position;
}

void drag(){
    this.gameObject.transform.position=Camera.main.ScreenToWorldPoint(Input.mousePosition);
}
void Update(){
    mPos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
    thisPos=this.gameObject.transform.position;
    float distance=(thisPos.x-mPos.x)*(thisPos.x-mPos.x)+(thisPos.y-mPos.y)*(thisPos.y-mPos.y);

    if(Input.GetMouseButtonDown(0)&&distance<=dragRange){
        drag();
    }else{
        this.gameObject.transform.position=defaultPos;
    }

}

}
