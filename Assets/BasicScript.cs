using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicScript : MonoBehaviour
{
    public vector3 rotation = new vector3(0, 2.0f, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void fixedUpdate()
    {
        if (Input.Getkey(KeyCode.R))
        {
            this.GetCompoment<Transform>().Rotate(rotation);
        }
        
    }
}
