using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitsData : MonoBehaviour
{
    public List<GameObject> UnitsList=new List<GameObject>();
    public List<GameObject> RunningUnitsList=new List<GameObject>();

    public void addRunningUnitsList(GameObject go){
        RunningUnitsList.Add(go);
    }
    public void getUnitsList(){
    }
    public GameObject getUnit(int index){
        return UnitsList[index];
    }
}
