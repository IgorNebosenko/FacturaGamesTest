using System;

namespace Core.Entities.Interfaces
{
    public interface IHaveHealth
    {
        event Action<float> OnHealthChanged; 
        event Action OnDeath;
        float MaxHealth { get; }
        float Health { get; }
        
        void InitHealth(float health);
        void TakeDamage(float damage);

        void Death();
    }
}