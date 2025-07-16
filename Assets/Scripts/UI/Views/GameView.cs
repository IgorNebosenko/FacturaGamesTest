using ElectrumGames.MVP;
using TMPro;
using UI.Presenters;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Views
{
    [AutoRegisterView]
    public class GameView : View<GamePresenter>
    {
        [SerializeField] private TMP_Text coinsText;
        [SerializeField] private TMP_Text levelText;
        [SerializeField] private Image progress;
        [SerializeField] private Button pauseButton;

        private void Start()
        {
            SetEmptyValues();
            
            pauseButton.onClick.AddListener(Presenter.OnPauseButtonClick);
        }

        private void OnDestroy()
        {
            pauseButton.onClick.RemoveListener(Presenter.OnPauseButtonClick);
        }

        private void SetEmptyValues()
        {
            coinsText.text = "000000";
            levelText.text = "Level: 00";
            progress.fillAmount = 0;
        }
        
        public void SetCoins(int value)
        {
            coinsText.text = $"{value:000000}";
        }

        public void SetLevel(int value)
        {
            levelText.text = $"Level: {value:00}";
        }

        public void SetProgress(float value)
        {
            progress.fillAmount = value;
        }
    }
}