using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private float speed = 6.0f;
    private float gravity = 20.0f;
    private float rotSpeed = 90.0f;

    private Vector3 moveDirection = Vector3.zero;
	
	// Update is called once per frame
	void Update () {
        PlayerMovoment();
	}

    void PlayerMovoment()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0);

        CharacterController controller = gameObject.GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = Vector3.forward * Input.GetAxis("Vertical");
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
