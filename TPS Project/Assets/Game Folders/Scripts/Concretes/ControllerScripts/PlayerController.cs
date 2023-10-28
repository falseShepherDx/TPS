using System;
using TPSProject.Abstracts.Inputs;
using TPSProject.Abstracts.Movements;
using TPSProject.Animations;
using TPSProject.Inputs;
using TPSProject.Movements;
using UnityEngine;

namespace TPSProject.Controllers
{
     public class PlayerController : MonoBehaviour
     {

         [Header("MovementFields")] [SerializeField]
         private float _moveSpeed;
         [SerializeField] private float _turnSpeed;
         [SerializeField] private Transform _turnTransform;
         
         private IInputReader _input;
         private IMover _mover;
         private Vector3 direction;
         private CharacterAnimation _animation;
         private Vector2 _rotation;
         private RotatorX _rotatorX;
         private RotatorY _rotatorY;
         public WeaponController _currentWeapon;
         
         public Transform TurnTransform => _turnTransform;
         private void Awake()
         {
             _input = GetComponent<IInputReader>();
             _mover = new CharacterControllerMovement(this);
             _animation = new CharacterAnimation(this);
             _rotation = _input.Rotation;
             _rotatorX = new RotatorX(this);
             _rotatorY = new RotatorY(this);
             

         }

         private void Update()
         {
             direction = _input.Direction;
             _rotatorX.RotationAction(_input.Rotation.x,_turnSpeed);
             _rotatorY.RotationAction(_input.Rotation.y,_turnSpeed);
             if (_input.AttackPressed)
             {
                 _currentWeapon.Shoot();
             }

             if (_input.ReloadPressed)
             {
                 _currentWeapon.Reload();
             }

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

