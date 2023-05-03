using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    // Start is called before the first frame update

    public void Start() => Light.enabled = false;

    // Update is called once per frame
    void Update()
    {
        
        bool held = Input.GetKey(KeyCode.L);
       

        if (held)
        {
            Light.enabled = true;
        }
      
        else
        {
            Light.enabled = false;
        }

     
    }
}
