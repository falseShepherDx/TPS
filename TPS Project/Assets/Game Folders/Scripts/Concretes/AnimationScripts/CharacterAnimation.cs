
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
        public void MoveAnimation()
        {
            
        }
        
    }
    
}

