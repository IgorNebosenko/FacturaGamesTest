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

            var direction = _playerInput.TurretDestination;

            if (direction.sqrMagnitude > 0.001f)
            {
                var angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(-90f, 0, angle);
            }
        }
    }
}