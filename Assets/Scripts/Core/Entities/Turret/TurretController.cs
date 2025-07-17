using Core.Input;
using UnityEngine;
using Zenject;

namespace Core.Entities.Turret
{
    public class TurretController : MonoBehaviour
    {
        private PlayerInput _playerInput;
        
        [Inject]
        private void Construct(InputActions inputActions)
        {
            _playerInput = new PlayerInput(inputActions);
            _playerInput.Init();
        }

        private void FixedUpdate()
        {
            _playerInput.Update();
            
            //Todo translate to rotation position
        }
    }
}