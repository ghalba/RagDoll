using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    private void Update()
    {
             float x = Input.GetAxisRaw("Horizontal");
             float z = Input.GetAxisRaw("Vertical");
            transform.position += new Vector3(-z,0, x)*Time.deltaTime*5f;
    }
}