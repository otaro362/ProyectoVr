using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velo2 : StateMachineBehaviour
{
    public GameObject canvas;
    //OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (canvas == null)
        {
            canvas = GameObject.Find("GameManager");
        }

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        canvas.GetComponent<GameManager>().correcto.SetActive(true);
    }

}
