using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 offset;
    public Transform player;

    // Start is called before the first frame update
    void Start(){
        offset = new Vector3(0, 5, -16); 
    }

    // Update is called once per frame
    void Update(){
        Vector3 rotatedOffset = player.rotation * offset;
        transform.position = player.position + rotatedOffset;
        transform.rotation = player.rotation;
    }
}
