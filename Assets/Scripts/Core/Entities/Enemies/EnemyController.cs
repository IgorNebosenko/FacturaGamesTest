using System;
using Core.Entities.Interfaces;
using Core.Entities.Interfaces.Motors;
using UnityEngine;

namespace Core.Entities.Enemies
{
    public class EnemyController : MonoBehaviour, IHaveHealth, IHaveMotor
    {
        public event Action<float> OnHealthChanged;
        public event Action OnDeath;
        public float MaxHealth { get; private set; }
        public float Health { get; private set; }
        public IMotor Motor { get; private set; }
        
        public void InitHealth(float health)
        {
            if (health <= 0)
            {
                Debug.LogError("Health of enemy <= 0, so method Death() invoked");
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