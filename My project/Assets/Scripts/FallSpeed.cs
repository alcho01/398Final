using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallSpeed : MonoBehaviour
{

    public int fallSpeed = -50;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, fallSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
