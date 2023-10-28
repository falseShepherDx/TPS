
using TPSProject.Controllers;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Assertions.Must;

namespace TPSProject.Movements
{
    public class RotatorY :IRotator
    {
        private Transform _transform;
        private float _tilt;

        public RotatorY(PlayerController playerController)
        {
            _transform = playerController.TurnTransform;
        }
        
        public void RotationAction(float direction,float turnSpeed)
        {
            direction *= turnSpeed * Time.deltaTime;
            _tilt = Mathf.Clamp(_tilt - direction, -30f, 30f);
            _transform.localRotation=Quaternion.Euler(_tilt,0f,0f);
        }
    }
}

