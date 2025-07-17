using Core.Entities.Player;
using ElectrumGames.MVP;
using ElectrumGames.MVP.Managers;
using UI.Views;

namespace UI.Presenters
{
    public class ClickAnywherePresenter : Presenter<ClickAnywhereView>
    {
        private readonly ViewManager _viewManager;
        private readonly PlayerController _playerController;
        
        public ClickAnywherePresenter(ViewManager viewManager, PlayerController playerController, ClickAnywhereView view) : base(view)
        {
            _viewManager = viewManager;
            _playerController = playerController;
        }

        public void OnBgButtonClick()
        {
            _viewManager.ShowView<GamePresenter>();
            _playerController.IsStoped = false;
        }
    }
}