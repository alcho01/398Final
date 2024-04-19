using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public OSC osc;
    public string levelToLoad;
    // Start is called before the first frame update
    void Start()
    {
        osc.SetAddressHandler("/wek/outputs", OnReceiveSwitch);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnReceiveSwitch(OscMessage message)
    {
        float x = message.GetFloat(9);
        float y = message.GetFloat(10);
        float z = message.GetFloat(11);

        transform.position = new Vector3(x, y, z);

        if (message.GetFloat(10) >= 2)
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
