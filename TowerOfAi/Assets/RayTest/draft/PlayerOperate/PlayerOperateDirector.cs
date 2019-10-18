using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOperateDirector : MonoBehaviour
{
    public GameObject choosingUnit;

    public void setChoosingUnit(GameObject go){
        choosingUnit=go;
    }
    void Start(){
        choosingUnit=GameObject.Find("UnitsData").GetComponent<UnitsData>().UnitsList[0];
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(choosingUnit);
        }
    }
}
