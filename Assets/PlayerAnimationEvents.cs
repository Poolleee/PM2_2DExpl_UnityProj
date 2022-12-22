using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationEvents : MonoBehaviour
{
    public AK.Wwise.Event Footstep_Event;
    public AK.Wwise.Event RoboArm_Event;
    public AK.Wwise.Event Landing_Event;
    public AK.Wwise.Event Jump_Event;
    public AK.Wwise.Event Tile_Event;
    public AK.Wwise.Switch Alien_Tiles_Switch;
    public AK.Wwise.Switch Grass_Switch;
    public AK.Wwise.Event Crouch_Event;

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

    public void PlayTile()
    {
        Tile_Event.Post(gameObject);
    }

    public void SetAlienTileSwitch()
    {
        Alien_Tiles_Switch.SetValue(gameObject);   
    }

    public void SetRockTileSwitch()
    {
        Grass_Switch.SetValue(gameObject);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
