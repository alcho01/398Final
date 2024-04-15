using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveRotationCamera : MonoBehaviour
{
    public OSC osc;


    // Start is called before the first frame update
    void Start()
    {
        osc.SetAddressHandler("/wek/outputs", OnReceiveXYZ);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnReceiveXYZ(OscMessage message)
    {
        float x = message.GetFloat(9);
        float y = message.GetFloat(10);
        float z = message.GetFloat(11);

        transform.rotation = Quaternion.Euler(x, y, z);
    }

}
