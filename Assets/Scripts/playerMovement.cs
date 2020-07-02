using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{
    public Transform player;
    public float smoothing = 7f;
    Camera mainCamera;
    Vector3 target;

    void Start(){
        mainCamera = Camera.main;

        GetComponent<BoxCollider2D>().size = new Vector2(
                mainCamera.orthographicSize *mainCamera.aspect * 2,
                mainCamera.orthographicSize * 2);
    }

    void OnMouseDown(){
        
        Debug.Log("Estamas pinchando");
        Vector3 mouse = Input.mousePosition;

        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        
        target = new Vector3(castPoint.origin.x, castPoint.origin.y, 0);

        StartCoroutine("movePlayer");

    }

    IEnumerator movePlayer(){
        Debug.Log("Estamos en la corutina");
        while(Vector2.Distance(player.transform.position, target) > 0.05f){
            player.transform.position = Vector3.Lerp(player.transform.position, target, smoothing * Time.deltaTime);
            yield return null;
        }
    } 
}