using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtInParent : MonoBehaviour
{
    public lookAtObject LookAtObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void lookAtParent(string tarjet)
    {
        LookAtObject.LookAtTarn(tarjet);
    }
}
