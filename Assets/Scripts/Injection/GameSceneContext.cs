using System.Reflection;
using Core.Entities.Player;
using UI;
using UnityEngine;

namespace Injection
{
    public class GameSceneContext : BaseSceneInstaller
    {
        [SerializeField] private PlayerController _playerController;
        
        protected override Assembly UiAssembly => typeof(UiAssemblyReference).Assembly;

        public override void InstallBindings()
        {
            base.InstallBindings();
            
            Container.BindInstance(_playerController).AsSingle();
        }
    }
}