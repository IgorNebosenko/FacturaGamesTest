using UnityEngine;

namespace Core.Entities.Interfaces.Motors
{
    public class PlayerMotor : IMotor
    {
        private readonly Transform _transform;
        private readonly float _speed;
        
        public PlayerMotor(Transform transform, float speed)
        {
            _transform = transform;
            _speed = speed;
        }

        public void Simulate(float deltaTime)
        {
            _transform.Translate(_transform.forward * _speed * deltaTime);
        }
    }
}