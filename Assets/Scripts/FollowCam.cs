using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{

    [SerializeField] GameObject player;
    // Camera should follow player


    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = player.transform.position + new Vector3(0,0,-10);        
    }
}
