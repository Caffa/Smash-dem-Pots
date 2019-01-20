using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform target;
    public float smoothing; // how quickly camera moves towards target

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Late Update is called once per frame & moves last
    void LateUpdate()
    {
        if(transform.position != target.position){

            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);

            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }
    }
}

