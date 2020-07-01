using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public Vector2 position;



    void OnMouseDown(){
        Debug.Log("hey negro");
        position.x ++;
        transform.Translate(position  * Time.deltaTime);
    }

}
