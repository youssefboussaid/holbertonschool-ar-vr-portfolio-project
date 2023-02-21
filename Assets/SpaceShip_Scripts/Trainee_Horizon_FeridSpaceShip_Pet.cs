using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Trainee_Horizon_FeridSpaceShip_Pet : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _stopDistance;
    private NavMeshAgent _navMeshAgent;


    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        _navMeshAgent.destination = _player.position;
        _navMeshAgent.stoppingDistance = _stopDistance;
    }
}
