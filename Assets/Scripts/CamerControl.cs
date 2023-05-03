using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerControl : MonoBehaviour
{

  
    public float hRange;
    public float vRange;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");
        float xPos = h * hRange;
        float vPos = v * vRange;
        transform.position = new Vector3(xPos, 0, vPos);
       
    }
}
