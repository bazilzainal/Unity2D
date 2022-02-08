using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    Renderer package;
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    bool hasPackage = false;

    SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Hit");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered");

        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            package = other.GetComponent<Renderer>();
            package.material.SetColor("_Color", Color.red);

            spriteRenderer.material.color = hasPackageColor;
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package DELIVERED.");
            hasPackage = false;
            package.material.SetColor("_Color", Color.green);
            Destroy(package.gameObject, destroyDelay);

            // Change the color to noPackageColor
            spriteRenderer.material.color = noPackageColor;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Exit");
    }

    private void Update()
    {
        // if (hasPackage) {
        //     GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        // }
    }
}
