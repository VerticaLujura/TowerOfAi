using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
public int hp;
public int attack;
public float moveSpeed=0.1f;

    private Vector3 MoveDirection;

void Move(){
    transform.Translate(MoveDirection);
}
void Start(){
    GameObject.Find("UnitsData").GetComponent<UnitsData>().AddRunningUnitsList(this.gameObject);
    Vector3 endpoint = GameObject.Find("P_UnitRunEndPoint").GetComponent<Transform>().position;//始点座標取得
    Vector3 startpoint = GameObject.Find("P_UnitRunStartPoint").GetComponent<Transform>().position;//終点座標取得
    float mv = moveSpeed / 1f;//
    float rad = Mathf.Atan2(endpoint.x - startpoint.x, endpoint.y - startpoint.y);
        MoveDirection = new Vector3(Mathf.Sin(rad) * mv, Mathf.Cos(rad) * mv, 0f);
}
void Update(){
    Move();
}
}
