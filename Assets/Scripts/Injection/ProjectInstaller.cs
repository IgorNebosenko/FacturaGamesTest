using Core.Entities.Bullets;
using Core.Entities.Configs;
using Core.Input;
using UnityEngine;
using Zenject;

namespace Injection
{
    public class ProjectInstaller : MonoInstaller
    {
        [SerializeField] private PlayerConfig playerConfig;
        [SerializeField] private BulletsData bulletsData;
        
        public override void InstallBindings()
        {
            Container.BindInstance(playerConfig).AsSingle();
            Container.BindInstance(bulletsData).AsSingle();
            
            Container.Bind<InputActions>().AsSingle();
        }
    }
}