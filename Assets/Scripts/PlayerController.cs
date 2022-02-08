using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float moveSpeed = 0.5f;
    [SerializeField] float turnSpeed = 1f;
    private SpriteRenderer test;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal") * turnSpeed * Time.deltaTime;
        float verticalInput = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;

        if (verticalInput > 0)
        {
            transform.Translate(0, verticalInput, 0);

        }
        else if (verticalInput < 0)
        {
            horizontalInput *= -1;
            // transform.Rotate(0, 0, horizontalInput);
            transform.Translate(0, verticalInput, 0);

        }
        transform.Rotate(0, 0, -horizontalInput);
    }
    // Update is called once per frame
    void FixedUpdate()
    {

    }

}
