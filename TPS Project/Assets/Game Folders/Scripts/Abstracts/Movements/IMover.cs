using UnityEngine;

namespace TPSProject.Abstracts.Movements
{
    public interface IMover
    {
        void MoveAction(Vector3 direction,float moveSpeed);
    }
    
}

