using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
     //Start is called before the first frame update
     void Start()
     {
         Debug.Log("hello world");
		 transform.position = new Vector2(Random.Range(-14,14),Random.Range(-8,8));
     }

    //Update is called once per frame
     void Update()
     {
        
     }
}
