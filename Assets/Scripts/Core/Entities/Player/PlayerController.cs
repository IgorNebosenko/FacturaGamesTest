using System;
using Core.Entities.Configs;
using Core.Entities.Interfaces;
using Core.Entities.Interfaces.Motors;
using ElectrumGames.Extensions.CommonInterfaces;
using UnityEngine;
using Zenject;

namespace Core.Entities.Player
{
    public class PlayerController : MonoBehaviour, IHaveMotor, IHaveHealth, IHavePosition
    {
        private PlayerConfig _playerConfig;

        public event Action<float> OnHealthChanged;
        public event Action OnDeath;
        public float MaxHealth { get; private set; }
        public float Health { get; private set; }
        public IMotor Motor { get; private set; }
        public Vector3 Position => transform.position;

        public bool IsStoped { get; set; } = true;

        [Inject]
        private void Construct(PlayerConfig playerConfig)
        {
            _playerConfig = playerConfig;
        }

        private void Start()
        {
            Motor = new PlayerMotor(transform, _playerConfig.Speed);
            
            InitHealth(_playerConfig.Health);
        }

        private void FixedUpdate()
        {
            if (!IsStoped)
                Motor.Simulate(Time.fixedDeltaTime);
        }

        public void InitHealth(float health)
        {
            if (health <= 0)
            {
                Debug.LogError("Player health <= 0, so method Death() invoked");
                Death();
                return;
            }

            Health = health;
            MaxHealth = health;
            OnHealthChanged?.Invoke(health);
        }

        public void TakeDamage(float damage)
        {
            if (damage <= 0)
            {
                Debug.LogError("Damage must be positive value! Nothing happens");
                return;
            }
            
            Health -= damage;
            
            OnHealthChanged?.Invoke(Health);
            
            if (Health <= 0)
                Death();
        }

        public void Death()
        {
            OnDeath?.Invoke();
        }
    }
}