using UnityEngine;
using Zenject;

namespace Core.Entities.Bullets
{
    public class BulletsSpawner : MonoBehaviour
    {
        private BulletsData _bulletsData;
        private BulletsPool _bulletsPool;

        private float _coolDownTime;
        
        [Inject]
        public void Construct(BulletsData bulletsData, BulletsPool bulletsPool)
        {
            _bulletsData = bulletsData;
            _bulletsPool = bulletsPool;
        }

        private void Update()
        {
            _coolDownTime += Time.deltaTime;
            
            if (_coolDownTime <= _bulletsData.Cooldown)
                return;

            _coolDownTime = 0f;

            var bullet = _bulletsPool.Spawn(_bulletsData);
            bullet.transform.position = transform.position;
        }
    }
}