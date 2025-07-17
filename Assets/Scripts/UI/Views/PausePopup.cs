using ElectrumGames.MVP;
using UI.Presenters;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Views
{
    [AutoRegisterView("Views/Popups/PausePopup")]
    public class PausePopup : View<PausePopupPresenter>
    {
        [SerializeField] private Button continueButton;
        [SerializeField] private Button exitButton;

        private void Start()
        {
            continueButton.onClick.AddListener(Presenter.OnContinueButtonClicked);
            exitButton.onClick.AddListener(Presenter.OnExitButtonClicked);
        }

        private void OnDestroy()
        {
            continueButton.onClick.RemoveListener(Presenter.OnContinueButtonClicked);
            exitButton.onClick.RemoveListener(Presenter.OnExitButtonClicked);
        }
    }
}