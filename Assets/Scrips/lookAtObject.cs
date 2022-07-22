using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LookAtTarn(string tarjet)
    {
        transform.LookAt(GameObject.Find(tarjet).transform);
    }
}
