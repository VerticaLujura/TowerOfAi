using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOperateDirector : MonoBehaviour
{
    public int choosingUnitIndex;
    List<GameObject> UnitsList;

    public  void CreateUnit(){
            Instantiate(UnitsList[choosingUnitIndex]);
            Debug.Log("UnitsList["+choosingUnitIndex+"]が生成されました");
    }
    public void ChangeChooosingUnitIndex(int x){
        choosingUnitIndex+=x;
        if(UnitsList.Count-1<choosingUnitIndex)choosingUnitIndex=0;
        if(choosingUnitIndex<0)choosingUnitIndex=UnitsList.Count;
        GameObject.Find("UnitImage").GetComponent<Image>().sprite
        =UnitsList[choosingUnitIndex].GetComponent<SpriteRenderer>().sprite;
            }
    void Start(){
        UnitsList=GameObject.Find("UnitsData").GetComponent<UnitsData>().UnitsList;
        choosingUnitIndex=0;
        var spr= UnitsList[choosingUnitIndex].GetComponent<SpriteRenderer>().sprite;
        GameObject.Find("UnitImage").GetComponent<Image>().sprite=spr;
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            ChangeChooosingUnitIndex(1);
        }
    }
}
