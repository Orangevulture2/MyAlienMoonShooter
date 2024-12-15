
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class Idlestate : Movementbasestate
{
    public override void EnterState(MovementStateManager Movement)
    {

    }

    public override void UpdateState(MovementStateManager Movement)
    {
        if(Movement.dir.magnitude>0.1f)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift)) Movement.SwitchState(Movement.Idle);
            else Movement.SwitchState(Movement.Walking);
        }
    }
}
