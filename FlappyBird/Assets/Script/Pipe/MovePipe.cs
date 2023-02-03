using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private float deadZone = -12;
    
    void Update()
    {
        //движение скалы влево
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        
        _DeletePipe();
    }
    
    void _DeletePipe()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
