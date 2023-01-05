using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_PressurePad_Event : MonoBehaviour
{
    public AK.Wwise.Event PressurePad_Event;
   public void PlayPressurePad()
    {
        PressurePad_Event.Post(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
