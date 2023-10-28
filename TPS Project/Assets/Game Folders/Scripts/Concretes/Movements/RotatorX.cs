using TPSProject.Controllers;
using UnityEngine;

namespace TPSProject.Movements
{
    public class RotatorX : IRotator
    {
        private PlayerController _playerController;

        public RotatorX(PlayerController playerController)
        {
            _playerController = playerController;
        }
        public void RotationAction(float direction,float turnSpeed)
        {
            _playerController.transform.Rotate(Vector3.up *direction* turnSpeed * Time.deltaTime);
        }
    }
    
}

