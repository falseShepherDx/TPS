using System;
using TPSProject.Abstracts.Inputs;
using UnityEngine;

namespace TPSProject.Controllers
{
     public class PlayerController : MonoBehaviour
     {
         private IInputReader _input;

         private void Awake()
         {
             _input = GetComponent<IInputReader>();
             
         }

         private void Update()
         {
            Debug.Log(_input.Direction);
         }
     }
    
}

