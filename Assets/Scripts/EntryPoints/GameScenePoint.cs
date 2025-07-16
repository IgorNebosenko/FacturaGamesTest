using ElectrumGames.MVP.Managers;
using UI.Presenters;
using UnityEngine;
using Zenject;

namespace EntryPoints
{
    public class GameScenePoint : MonoBehaviour
    {
        private ViewManager _viewManager;
        
        [Inject]
        private void Construct(ViewManager viewManager)
        {
            _viewManager = viewManager;
            _viewManager.ShowView<ClickAnywherePresenter>();
        }
    }
}