using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovePlayer : MonoBehaviour
{
    public Transform tarjet1;
    public Transform[] place;
    public AudioClip[] audioClips;
    public AudioSource audioSource;
    public NavMeshAgent agent;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name== "PersonajeMujer2")
        {
            agent = GetComponentInParent<NavMeshAgent>();
        }
        else
        {
            agent = GetComponent<NavMeshAgent>();
        }
        
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MovePlayerMas(Transform tarjet)
    {
        agent.SetDestination(tarjet.transform.position);
        animator.SetBool("Walk", true);
    }
    public void Distance(Transform player, Transform destino, float comparate)
    {
        if (Vector3.Distance(player.position, destino.position) < comparate)
        {
            animator.SetBool("Walk", false);
        }
    }
}
