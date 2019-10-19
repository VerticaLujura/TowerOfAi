using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateButton : MonoBehaviour
{
    public void OnClick(){
        GameObject.Find("PlayerOperateDirector").GetComponent<PlayerOperateDirector>().createUnit();
    }
}
