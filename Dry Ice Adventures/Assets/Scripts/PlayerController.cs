using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Config Parameters
    public int movementSpeed = 200;
    private float moveX;
    private float moveY;

    // Cached References
    private Rigidbody2D myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        myRigidbody.velocity = new Vector2(moveX * movementSpeed * Time.deltaTime, moveY * movementSpeed * Time.deltaTime);
    }
}
