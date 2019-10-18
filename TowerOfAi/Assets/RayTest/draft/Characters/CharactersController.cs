using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersController : MonoBehaviour
{
    public List<GameObject> characterList;
    public GameObject Unit1;
    public GameObject Unit2;
    public GameObject Unit3;
    public GameObject Unit4;
    void Awake()
    {
        Initial();
    }

    void Initial(){
        void setList(GameObject go){
            characterList.Add(go);
        }
        setList(Unit1);
        setList(Unit2);
        setList(Unit3);
        setList(Unit4);
    }
}
