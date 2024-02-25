using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAI : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    Animator animator;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);

        if (agent.velocity == Vector3.zero)
            animator.SetInteger("State", 0);
        else
            animator.SetInteger("State", 1);
    }
}
