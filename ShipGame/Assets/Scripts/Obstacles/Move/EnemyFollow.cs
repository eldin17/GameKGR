using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace ShipGame
{
    public class EnemyFollow : MonoBehaviour
    {
        public NavMeshAgent Enemy;
        public Transform Player;
        private void Start()
        {

        }
        private void Update()
        {
            Enemy.SetDestination(Player.position);
            transform.LookAt(Player);
        }
        //    public EnemyCanon Shooting;
        //    public NavMeshAgent Enemy;
        //    public Transform Player;
        //    public LayerMask Ground, Player1;
        //    public float sightRange, attackRange;
        //    public bool playerInSightRange, playerInAttackRange;
        //    private void Start()
        //    {
        //        Shooting.enabled = false;
        //    }
        //    private void Update()
        //    {
        //        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, Player1);
        //        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, Player1);

        //        if (playerInSightRange && !playerInAttackRange) 
        //            Follow();
        //        if (playerInSightRange && !playerInAttackRange)
        //            Attack();
        //    }
        //    private void Follow()
        //    {
        //        Enemy.SetDestination(Player.position);
        //        transform.LookAt(Player);
        //    }
        //    private void Attack()
        //    {
        //        Shooting.enabled = true;
        //        transform.LookAt(Player);
        //    }
        //}
    }
}
