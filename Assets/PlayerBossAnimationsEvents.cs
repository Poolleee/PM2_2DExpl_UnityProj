using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBossAnimationsEvents : MonoBehaviour
{
    public AK.Wwise.Event Footstep_Event;
    public AK.Wwise.Event CryBoss_Event;
    public AK.Wwise.Event BeamBossAttack_Event;
    public AK.Wwise.Event BeamBossCharge_Event;
    public AK.Wwise.Event ElectricBossAttack_Event;
    public AK.Wwise.Event ElectricBossCharge_Event;
    public AK.Wwise.Event GranadeBossThrow_Event;
    public AK.Wwise.Event HitBoss_Event;

    public void PlayBossFootstep()
    {
        Footstep_Event.Post(gameObject);
    }

    public void PlayCryBoss()
    {
        CryBoss_Event.Post(gameObject);
    }

    public void PlayElectricBossAttack()
    {
        ElectricBossAttack_Event.Post(gameObject);
    }

    public void PlayElectricBossCharge()
    {
        ElectricBossCharge_Event.Post(gameObject);
    }

    public void PlayBeamBossAttack()
    {
        BeamBossAttack_Event.Post(gameObject);
    }

    public void PlayBeamBossCharge()
    {
        BeamBossCharge_Event.Post(gameObject);
    }

    public void PlayGranadeBossThrow()
    {
        GranadeBossThrow_Event.Post(gameObject);
    }

    public void PlayHitBoss()
    {
        HitBoss_Event.Post(gameObject);
    }

}
