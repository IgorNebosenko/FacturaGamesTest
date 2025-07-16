using System;

namespace Core.Entities.Interfaces
{
    public interface IHaveHealth
    {
        event Action OnDeath;
        int Health { get; }
        
        void Init(int health);
        void TakeDamage(int damage);

        void Death();
    }
}