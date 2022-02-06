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
        test = GetComponent<SpriteRenderer>();
        test.color = Color.cyan;

        Debug.Log("Testing");

    }

    private void Update()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        // float horizontalInput = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        // float verticalInput = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
        // transform.Translate(new Vector2(horizontalInput, verticalInput));

        transform.Translate(0, moveSpeed, 0);
        transform.Rotate(0, 0, turnSpeed);

    }

}
