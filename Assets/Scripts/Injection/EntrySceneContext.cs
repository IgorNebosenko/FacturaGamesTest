using System.Reflection;
using UI;

namespace Injection
{
    public class EntrySceneContext : BaseSceneInstaller
    {
        protected override Assembly UiAssembly => typeof(UiAssemblyReference).Assembly;

        public override void InstallBindings()
        {
            base.InstallBindings();
            
            
        }
    }
}