using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    float speed = 0.1f;

    void Update(){
        if (Input.GetKey(KeyCode.J)) transform.Rotate(0,-3,0);
        if (Input.GetKey(KeyCode.K)) transform.Rotate(0,3,0);
        transform.Translate(new Vector3(Input.GetAxis("Horizontal")*speed, 0f, Input.GetAxis("Vertical")*speed));
    }
}
