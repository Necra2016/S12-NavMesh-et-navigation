using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class agentBase : MonoBehaviour
{
    private NavMeshAgent _agent;
    [SerializeField] GameObject _Joueur;

    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
                _agent.SetDestination(_Joueur.transform.position);

    }
}
