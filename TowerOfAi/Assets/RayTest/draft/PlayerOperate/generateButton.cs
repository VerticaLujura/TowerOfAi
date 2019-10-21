using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateButton : MonoBehaviour
{
    public void OnClick(){
        GameObject.Find("PlayerOperateDirector").GetComponent<PlayerOperateDirector>().CreateUnit();
    }
}
