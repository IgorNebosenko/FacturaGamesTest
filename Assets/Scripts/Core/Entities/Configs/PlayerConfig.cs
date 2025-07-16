using UnityEngine;

namespace Core.Entities.Configs
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Entities/PlayerConfig")]
    public class PlayerConfig : ScriptableObject
    {
        [field: SerializeField] public float Speed { get; private set; }
        [field: SerializeField] public float Health { get; private set; }
    }
}