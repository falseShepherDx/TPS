using UnityEngine;
using UnityEngine.UI;

namespace TPSProject.Abstracts.Inputs
{
    public interface IInputReader 
    {
        Vector3 Direction { get; }
    }
}

