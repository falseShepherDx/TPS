using System.Collections;
using System.Collections.Generic;
using TPSProject.Abstracts.Controllers;
using TPSProject.Abstracts.Movements;
using TPSProject.Controllers;
using UnityEngine;
using UnityEngine.AI;

namespace TPSProject.Movements
{
    public class MoveWithNavMesh : IMover
    {
        private NavMeshAgent _navMeshAgent;

        public MoveWithNavMesh(IEntityController _entityController )
        {
            
            _navMeshAgent = _entityController?.Transform.GetComponent<NavMeshAgent>();
        }
        public void MoveAction(Vector3 direction, float moveSpeed)
        {
            _navMeshAgent.SetDestination(direction);
        }
    }
}

