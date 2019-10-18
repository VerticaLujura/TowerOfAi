using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitsData : MonoBehaviour
{
    public List<GameObject> UnitsList=new List<GameObject>();
    public void addUnitsList(GameObject go){
        UnitsList.Add(go);
    }
    
}
