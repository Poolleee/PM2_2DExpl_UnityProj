using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_Boss_State : MonoBehaviour
{
    public AK.Wwise.State Boss_Stage1;
    public AK.Wwise.State Boss_Stage2;
    public AK.Wwise.State Boss_Stage3;
    public AK.Wwise.State Boss_Exit;
    public void SetBossStage1()
    {
        Boss_Stage1.SetValue();
    }

    public void SetBossStage2()
    {
        Boss_Stage2.SetValue();
    }

    public void SetBossStage3()
    {
        Boss_Stage3.SetValue();
    }

    public void SetBossExit()
    {
        Boss_Exit.SetValue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
