using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : MonoBehaviour
{
     //Start is called before the first frame update
	 public GameObject Room;
	
     void Start()
     {
         Debug.Log("hello world");
		// transform.position = new Vector2(Random.Range(-14,14),Random.Range(-8,8));
     }

    //Update is called once per frame
     void Update()
     {
        Instantiate(Room);
		Room.transform.position = new Vector2(Random.Range(-9,10),Random.Range(-9,10));
     }
}
