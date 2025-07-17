using System.Reflection;
using Core.Entities.Bullets;
using Core.Entities.Player;
using UI;
using UnityEngine;

namespace Injection
{
    public class GameSceneContext : BaseSceneInstaller
    {
        [SerializeField] private PlayerController _playerController;
        [Space]
        [SerializeField] private BulletController bullet;
        
        protected override Assembly UiAssembly => typeof(UiAssemblyReference).Assembly;

        public override void InstallBindings()
        {
            base.InstallBindings();
            
            Container.BindInstance(_playerController).AsSingle();
            
            Container.BindMemoryPool<BulletController, BulletsPool>().WithInitialSize(15)
                .FromComponentInNewPrefab(bullet).UnderTransformGroup("Bullets");
        }
    }
}