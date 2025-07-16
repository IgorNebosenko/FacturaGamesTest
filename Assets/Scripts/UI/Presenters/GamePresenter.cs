using ElectrumGames.MVP;
using ElectrumGames.MVP.Managers;
using UI.Views;
using UnityEngine;

namespace UI.Presenters
{
    public class GamePresenter : Presenter<GameView>
    {
        private readonly PopupManager _popupManager;
        public GamePresenter(PopupManager popupManager, GameView view) : base(view)
        {
            _popupManager = popupManager;
        }

        public void OnPauseButtonClick()
        {
            Time.timeScale = 0;
            //ToDo popup of pause
        }
    }
}