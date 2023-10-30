using System;
using TPSProject.Abstracts.Controllers;
using TPSProject.Abstracts.Movements;
using TPSProject.Movements;
using UnityEngine;

namespace TPSProject.Controllers
{
    public class EnemyController : MonoBehaviour,IEntityController
    {
        public Transform Transform { get; private set; }
        [SerializeField] private Transform _player;
        private IMover _mover;
        private void Start()
        {
            _mover = new MoveWithNavMesh(this);
        }

        private void Update()
        {
            _mover.MoveAction(_player.transform.position,10f);
        }
    }
}

