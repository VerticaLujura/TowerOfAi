using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
public int hp;
public int attack;
public float moveSpeed=0.1f;

void move(){
    transform.Translate(new Vector3(moveSpeed,0,0));
}
void Start(){
    GameObject.Find("UnitsData").GetComponent<UnitsData>().addUnitsList(this.gameObject);
}
void Update(){
    move();
}
}
