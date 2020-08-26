using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCamera : MonoBehaviour
{
    public FollowCamera FollowCamera;
    public Vector3 pivotOffset = Vector3.zero;
    public float targetX = 45f;
    public float targetY = 45f;
    public float targetZ = 0f;
    public float TargetDistance = 5f;
    public float SmoothTime = 1f;
    public float needtime = 1f;

    private bool haveEnter = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<twoshpere>() != null && !haveEnter)
        {
            haveEnter = true;
            print("aaaaaaa");
            FollowCamera.pivotOffset = pivotOffset;
            FollowCamera.targetX = targetX;
            FollowCamera.targetY = targetY;
            FollowCamera.targetZ = targetZ;
            FollowCamera.TargetDistance = TargetDistance;
            FollowCamera.SmoothTime = SmoothTime;
            FollowCamera.needtime = needtime;
        }

    }
}
