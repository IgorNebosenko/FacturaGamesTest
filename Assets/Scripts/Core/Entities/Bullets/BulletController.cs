using System;
using Core.Entities.Interfaces;
using UniRx;
using UnityEngine;

namespace Core.Entities.Bullets
{
    public class BulletController : MonoBehaviour
    {
        private BulletsData _bulletsData;
        private IDisposable _returnProcess;
        
        [SerializeField] private Rigidbody physics;
        
        public void Init(BulletsData data)
        {
            _bulletsData = data;

            _returnProcess = Observable.Timer(TimeSpan.FromSeconds(_bulletsData.Lifetime)).Subscribe(_ => Despawn());
            
            physics.velocity = transform.forward * _bulletsData.Speed;
        }

        public void Despawn()
        {
            _returnProcess?.Dispose();
            
            physics.velocity = Vector3.zero;
            gameObject.SetActive(false);
        }

        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("OnCollisionEnter!");
            
            if (collision.gameObject.TryGetComponent<IHaveHealth>(out var haveHealth))
            {
                haveHealth.TakeDamage(_bulletsData.Damage);
            }
            
            Despawn();
        }
    }
}