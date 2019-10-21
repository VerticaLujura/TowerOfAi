using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitsData : MonoBehaviour
{
    public List<GameObject> UnitsList=new List<GameObject>();
    public List<GameObject> RunningUnitsList=new List<GameObject>();

    public void AddRunningUnitsList(GameObject go){
        RunningUnitsList.Add(go);
    }
    public List<GameObject> GetUnitsList(){
        return UnitsList;
    }
    public GameObject GetUnit(int index){
        return UnitsList[index];
    }
}
