using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Testing");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        float verticalInput = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(new Vector2(horizontalInput, verticalInput));
    }

}
