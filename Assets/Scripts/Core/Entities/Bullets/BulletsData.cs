using UnityEngine;

namespace Core.Entities.Bullets
{
    [CreateAssetMenu(fileName = "BulletsData", menuName = "Entities/BulletsData")]
    public class BulletsData : ScriptableObject
    {
        [field: SerializeField] public float Speed { get; private set; }
        [field: SerializeField] public float Damage { get; private set; }
        [field: SerializeField] public float Lifetime { get; private set; }
        [field: SerializeField] public float Cooldown { get; private set; }
    }
}