
using TPSProject.Controllers;
using UnityEngine;

namespace TPSProject.Animations
{public class CharacterAnimation
    {
        private Animator _animator;

        public CharacterAnimation(PlayerController player)
        {
            _animator = player.GetComponentInChildren<Animator>();
        }
        public void MoveAnimation(float moveSpeed)
        {
            if (_animator.GetFloat("moveSpeed") == moveSpeed) return;

            _animator.SetFloat("moveSpeed",moveSpeed,0.1f,Time.deltaTime);
        }
        
    }
    
}

