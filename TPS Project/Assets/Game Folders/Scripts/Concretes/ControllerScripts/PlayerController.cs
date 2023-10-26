using System;
using TPSProject.Abstracts.Inputs;
using TPSProject.Abstracts.Movements;
using TPSProject.Animations;
using TPSProject.Movements;
using UnityEngine;

namespace TPSProject.Controllers
{
     public class PlayerController : MonoBehaviour
     {

         [Header("MovementFields")] [SerializeField]
         private float _moveSpeed;
         
         private IInputReader _input;
         private IMover _mover;
         private Vector3 direction;
         private CharacterAnimation _animation;
         private void Awake()
         {
             _input = GetComponent<IInputReader>();
             _mover = new CharacterControllerMovement(this);
             _animation = new CharacterAnimation(this);

         }

         private void Update()
         {
             direction = _input.Direction;
         }

         private void FixedUpdate()
         {
             
            _mover.MoveAction(direction,_moveSpeed);

         }

         private void LateUpdate()
         {
             _animation.MoveAnimation(direction.magnitude);
         }
     }
    
}

