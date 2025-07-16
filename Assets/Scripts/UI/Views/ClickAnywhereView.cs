using ElectrumGames.MVP;
using UI.Presenters;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Views
{
    [AutoRegisterView]
    public class ClickAnywhereView : View<ClickAnywherePresenter>
    {
        [SerializeField] private Button bgButton;

        private void Start()
        {
            bgButton.onClick.AddListener(Presenter.OnBgButtonClick);
        }

        private void OnDestroy()
        {
            bgButton.onClick.RemoveListener(Presenter.OnBgButtonClick);
        }
    }
}