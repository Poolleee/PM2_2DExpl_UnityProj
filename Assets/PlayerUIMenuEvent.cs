using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUIMenuEvent : MonoBehaviour
{
    public AK.Wwise.Event Highlighted_button_Event;
    
   public void PlayHihglightedButton()
    {
        Highlighted_button_Event.Post(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
