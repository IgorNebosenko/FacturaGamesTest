using System;
using Core.Entities.Interfaces;
using UnityEngine;

namespace Core.Entities.Player
{
    public class PlayerController : MonoBehaviour, IHaveMotor, IHaveHealth
    {
        public event Action OnDeath;
        public int Health { get; private set; }
        
        public void Init(int health)
        {
            if (health <= 0)
            {
                Debug.LogError("Player health <= 0, so method Death() invokes");
                Death();
                return;
            }

            Health = health;
        }

        public void TakeDamage(int damage)
        {
            if (damage <= 0)
            {
                Debug.LogError("Damage must be positive value! Nothing happens");
                return;
            }
            
            Health -= damage;
            
            if (Health <= 0)
                Death();
        }

        public void Death()
        {
            OnDeath?.Invoke();
        }
    }
}