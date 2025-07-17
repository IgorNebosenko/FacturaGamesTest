using System.Collections.Generic;
using ElectrumGames.MVP;
using ElectrumGames.MVP.Utils;
using UI.Views;
using UnityEngine;

namespace UI.Presenters
{
    public class PausePopupPresenter : PopupPresenterCoroutine<PausePopup, PopupArgs, PopupResult>
    {
        public PausePopupPresenter(PausePopup view) : base(view)
        {
        }

        public override IEnumerable<PopupResult> Init(PopupArgs args)
        {
            yield break;
        }

        public void OnContinueButtonClicked()
        {
            Time.timeScale = 1;
            Close();
        }
        
        public void OnExitButtonClicked()
        {
            Application.Quit();
        }
    }
}