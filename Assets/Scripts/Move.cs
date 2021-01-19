using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float movementSpeed;  
    
    void Start()
    {

    }

    
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");
        
        Vector3 playerMovement = new Vector3(xAxis, 0f, zAxis) * movementSpeed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);

    }
}
