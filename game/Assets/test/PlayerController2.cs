using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : PortalableObject
{
    private CameraMove cameraMove;

    protected override void Awake()
    {
        base.Awake();

        cameraMove = GetComponent<CameraMove>();
    }

    public override void Warp()
    {
        base.Warp();
        cameraMove.ResetTargetRotation();
    }
}
