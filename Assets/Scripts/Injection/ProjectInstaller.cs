using Core.Entities.Configs;
using Core.Input;
using UnityEngine;
using Zenject;

namespace Injection
{
    public class ProjectInstaller : MonoInstaller
    {
        [SerializeField] private PlayerConfig playerConfig;
        
        public override void InstallBindings()
        {
            Container.BindInstance(playerConfig).AsSingle();
            
            Container.Bind<InputActions>().AsSingle();
        }
    }
}