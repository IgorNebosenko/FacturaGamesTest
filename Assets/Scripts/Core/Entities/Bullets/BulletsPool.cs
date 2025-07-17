using UnityEngine;
using Zenject;

namespace Core.Entities.Bullets
{
    public class BulletsPool : MonoMemoryPool<BulletsData, BulletController>
    {
        protected override void Reinitialize(BulletsData data, BulletController bullet)
        {
            bullet.gameObject.SetActive(true);
            bullet.transform.position = Vector3.zero;
            bullet.Init(data);
        }

        protected override void OnDespawned(BulletController bullet)
        {
            bullet.gameObject.SetActive(false);
        }
    }
}