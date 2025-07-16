using ElectrumGames.MVP;
using ElectrumGames.MVP.Managers;
using UI.Views;

namespace UI.Presenters
{
    public class ClickAnywherePresenter : Presenter<ClickAnywhereView>
    {
        private readonly ViewManager _viewManager;
        
        public ClickAnywherePresenter(ViewManager viewManager, ClickAnywhereView view) : base(view)
        {
            _viewManager = viewManager;
        }

        public void OnBgButtonClick()
        {
            _viewManager.ShowView<GamePresenter>();
        }
    }
}