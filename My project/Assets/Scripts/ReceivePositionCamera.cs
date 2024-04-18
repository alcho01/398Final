using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceivePositionCamera : MonoBehaviour
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
        float x = message.GetFloat(3);
        float y = message.GetFloat(4);
        float z = message.GetFloat(5);

        transform.position = new Vector3(x, y, z);
    }
}