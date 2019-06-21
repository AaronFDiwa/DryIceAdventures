using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    // Config Parameters
    private GameObject player;

    // Cached References
    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
        // Store current camera position in varaible temp
        Vector3 temp = transform.position;

        // Set camera position x/y to be equal to player's position x/y
        temp.x = playerTransform.position.x;
        temp.y = playerTransform.position.y;

        // Set back camera's temp position to camera's current positon
        transform.position = temp;
    }
}
