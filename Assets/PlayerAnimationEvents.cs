using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationEvents : MonoBehaviour
{
    public AK.Wwise.Event Footstep_Event;
    public AK.Wwise.Event RoboArm_Event;
    public AK.Wwise.Event Landing_Event;
    public AK.Wwise.Event Jump_Event;
    public AK.Wwise.Switch Alien_Tiles_Switch;
    public AK.Wwise.Switch Grass_Switch;
    public AK.Wwise.Event Crouch_Event;
    public AK.Wwise.Event Melee_Event;
    public AK.Wwise.Event Gun_Event;
    public AK.Wwise.Event Hurt_Event;
    public AK.Wwise.Event Die_Event;
    public AK.Wwise.Event Fall_Event;

    public void PlayFootstep()
    {
        Footstep_Event.Post(gameObject);
    }

    public void PlayCrouch()
    {
        Crouch_Event.Post(gameObject);
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

    public void SetAlienTileSwitch()
    {
        Alien_Tiles_Switch.SetValue(gameObject);   
    }

    public void SetRockTileSwitch()
    {
        Grass_Switch.SetValue(gameObject);
    }

    public void PlayMelee()
    {
        Melee_Event.Post(gameObject);
    }

    public void PlayGun()
    {
        Gun_Event.Post(gameObject);
    }

    public void PlayHurt()
    {
        Hurt_Event.Post(gameObject);
    }

    public void PlayDie()
    {
        Die_Event.Post(gameObject);
    }

    public void PlayFall()
    {
        Fall_Event.Post(gameObject);
    }

}
