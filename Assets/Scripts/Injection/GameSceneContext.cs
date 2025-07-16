using System.Reflection;
using UI;

namespace Injection
{
    public class GameSceneContext : BaseSceneInstaller
    {
        protected override Assembly UiAssembly => typeof(UiAssemblyReference).Assembly;
    }
}