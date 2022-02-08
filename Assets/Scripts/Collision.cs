using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public int kickForce = 10;

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Hit");    
        Vector3 direction = (other.transform.position - transform.position).normalized;
        GetComponent<Rigidbody2D>().AddForce(-direction * kickForce, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Triggered");
    }

    private void OnTriggerExit2D(Collider2D other) {
        Debug.Log("Exit");
    }
}
