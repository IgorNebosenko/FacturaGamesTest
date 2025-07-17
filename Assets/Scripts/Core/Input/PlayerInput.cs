using UnityEngine;
using UnityEngine.InputSystem;

namespace Core.Input
{
    public class PlayerInput : IInput, InputActions.IDefaultActions
    {
        private readonly InputActions _inputActions;

        private bool _isTurretUpdated;
        
        public Vector2 TurretDestination { get; private set; }

        public PlayerInput(InputActions actions)
        {
            _inputActions = actions;
        }

        public void Init()
        {
            _inputActions.Default.SetCallbacks(this);
            _inputActions.Enable();
        }

        public void Update()
        {
            if (!_isTurretUpdated)
            {
                TurretDestination = Vector2.zero;
                return;
            }
            
            TurretDestination = _inputActions.Default.Turret.ReadValue<Vector2>();
        }

        public void OnTurret(InputAction.CallbackContext context)
        {
            _isTurretUpdated = context.phase != InputActionPhase.Canceled;
        }
    }
}