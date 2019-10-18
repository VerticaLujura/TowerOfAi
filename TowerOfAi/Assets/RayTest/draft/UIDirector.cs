using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDirector : MonoBehaviour
{
    public GameObject characters;
    public GameObject choicedChara;
    public List<GameObject> characterList;

    void keyAct(KeyCode key,GameObject go){
        if(Input.GetKeyDown(key)){
            Instantiate(go);
        }
    }
    
    void Start()
    {characterList=characters.GetComponent<CharactersController>().characterList;
    }

    // Update is called once per frame
    void Update()
    {
        keyAct(KeyCode.Alpha1,characterList[0]);
        keyAct(KeyCode.Alpha2,characterList[1]);
        keyAct(KeyCode.Alpha3,characterList[2]);
        keyAct(KeyCode.Alpha4,characterList[3]);
    }
}
