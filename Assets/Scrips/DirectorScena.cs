using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectorScena : MonoBehaviour
{
    public float time;
    public Animator playerM;
    public Animator playerF;
    public float time1;
    public float time2;
    public float time3;
    public float time4;
    public bool door;
    public bool silla;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time>time1&&time<time2)
        {
            door = true;
        }
        if (time > time3 && time < time4)
        {

        }
        if (door)
        {
            playerM.gameObject.GetComponent<MovePlayer>().tarjet1 = playerM.gameObject.GetComponent<MovePlayer>().place[0];
            door = false;
        }

    }
    public void WalkFem()
    {
        playerF.SetBool("Walk", true);
    }
    public void KissMac()
    {
        playerM.SetBool("Kiss", true);
    }
    
}
