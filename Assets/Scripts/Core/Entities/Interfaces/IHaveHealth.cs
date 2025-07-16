using System;

namespace Core.Entities.Interfaces
{
    public interface IHaveHealth
    {
        event Action OnDeath;
        float Health { get; }
        
        void InitHealth(float health);
        void TakeDamage(float damage);

        void Death();
    }
}