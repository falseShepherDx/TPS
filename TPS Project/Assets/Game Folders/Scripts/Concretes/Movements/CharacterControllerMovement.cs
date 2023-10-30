using TPSProject.Abstracts.Controllers;
using TPSProject.Abstracts.Movements;
using TPSProject.Controllers;
using UnityEngine;

namespace TPSProject.Movements
{
    public class CharacterControllerMovement : IMover
    {
        CharacterController _characterController;


        public CharacterControllerMovement(IEntityController _entityController)
        {
            _characterController = _entityController.Transform.GetComponent<CharacterController>();
            
        }
        
        public void MoveAction(Vector3 direction, float moveSpeed)
        {
            if (direction.magnitude == 0f) return;
            Vector3 worldPosition = _characterController.transform.TransformDirection(direction);
            Vector3 movement = worldPosition * (moveSpeed * Time.deltaTime);
            _characterController.Move(movement);

        }
    }
}

