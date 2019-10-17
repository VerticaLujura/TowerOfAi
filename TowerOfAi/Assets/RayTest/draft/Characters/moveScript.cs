using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
     this.gameObject.transform.Translate(new Vector3(0.1f,0,0));   
    }
}
