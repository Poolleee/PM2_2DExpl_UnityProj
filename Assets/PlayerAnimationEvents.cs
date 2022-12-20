using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationEvents : MonoBehaviour
{
    public AK.Wwise.Event Footstep_Event;
    public AK.Wwise.Event RoboArm_Event;
    public AK.Wwise.Event Landing_Event;
    public AK.Wwise.Event Jump_Event;

   public void PlayFootstep()
    {
        Footstep_Event.Post(gameObject);
    }

   public void PlayRoboArm()
    {
        RoboArm_Event.Post(gameObject);
    }

    public void PlayLanding()
    {
        Landing_Event.Post(gameObject);
    }

    public void PlayJump()
    {
        Jump_Event.Post(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
