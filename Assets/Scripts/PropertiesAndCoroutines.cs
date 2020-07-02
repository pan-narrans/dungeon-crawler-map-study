using UnityEngine;
using System.Collections;

public class PropertiesAndCoroutines : MonoBehaviour
{
    public float smoothing = 7f;
    public Vector2 Target
    {
        get { return target; }
        set
        {
            target = value;

            StopCoroutine("Movement");
            StartCoroutine("Movement", target);
        }
    }

    private Vector2 target;




    IEnumerator Movement (Vector2 target)
    {
        while(Vector2.Distance(transform.position, target) > 0.05f)
        {
            transform.position = Vector2.Lerp(transform.position, target, smoothing * Time.deltaTime);

            yield return null;
        }
    }

    void OnMouseUp (){

        Target = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Debug.Log(Target + "  " + target);
    }

}