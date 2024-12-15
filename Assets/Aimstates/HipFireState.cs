
using UnityEngine;

public class HipFireState : AimBase
{
    public override void EnterState(AimStateManager aim)
    {
        aim.anim.SetBool("Aiming", false);
    }
    public override void UpdateState(AimStateManager aim) 
    {
        if (Input.GetKey(KeyCode.Mouse1)) aim.SwitchState(aim.Aim);
    }
}
