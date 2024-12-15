using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walkingstate : Movementbasestate
{
    public override void EnterState(MovementStateManager Movement)
    {
        Movement.anim.SetBool("Walking", true);
    }

    public override void UpdateState(MovementStateManager Movement)
    {

    }
}
