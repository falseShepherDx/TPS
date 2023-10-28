using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPSProject.Movements
{
    public class Gravity : MonoBehaviour
    {
        [SerializeField] private float gravity = -9.81f;
        private CharacterController _characterController;
        private Vector3 _velocity;

        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
            
        }

        private void Update()
        {
            if (_characterController.isGrounded) _velocity.y = 0;
            _velocity.y += gravity * Time.deltaTime;
            _characterController.Move(_velocity * Time.deltaTime);
        }
    }

}
