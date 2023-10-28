using UnityEngine;
using UnityEngine.UI;

namespace TPSProject.Abstracts.Inputs
{
    public interface IInputReader 
    {
        Vector3 Direction { get; }
        Vector2 Rotation { get; }
         bool AttackPressed { get; }
         bool ReloadPressed { get;}
    }
}

