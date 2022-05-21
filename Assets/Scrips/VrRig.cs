using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
//https://www.youtube.com/watch?v=tBYl-aSxUe0&list=WL&index=113
public class VRMap
{
    public Transform vrTraget;
    public Transform rigTarget;
    public Vector3 trackingpositionOffset;
    public Vector3 trakingRotationOffset;
    public void Map()
    {
        rigTarget.position = vrTraget.TransformPoint(trackingpositionOffset);
        rigTarget.rotation = vrTraget.rotation * Quaternion.Euler(trakingRotationOffset);
    }
}
public class VrRig : MonoBehaviour
{
    public VRMap head;
    public VRMap lefHand;
    public VRMap rightHand;
    public Transform headConstrains;
    public Vector3 headbodyOffest;
    void Start()
    {
        headbodyOffest = transform.position - headConstrains.position;

    }

    
    void Update()
    {
        transform.position = headConstrains.position + headbodyOffest;
        transform.forward = Vector3.ProjectOnPlane(headConstrains.up, Vector3.up).normalized;

        head.Map();
        lefHand.Map();
        rightHand.Map();
    }
}
