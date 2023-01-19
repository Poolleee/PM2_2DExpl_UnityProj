using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfopostEvent : MonoBehaviour
{
    public AK.Wwise.Event InfoPost_Event;
    public void PlayInfoPost()
    {
        InfoPost_Event.Post(gameObject);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
