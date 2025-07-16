using System;
using Common;
using ElectrumGames.MVP.Managers;
using UI.Presenters;
using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace EntryPoints
{
    public class EntryScenePoint : MonoBehaviour
    {
        [SerializeField] private float splashScreenDuration = 1.5f;
        
        private ViewManager _viewManager;

        [Inject]
        private void Construct(ViewManager viewManager)
        {
            _viewManager = viewManager;

            _viewManager.ShowView<EntryPresenter>();
            
            Observable.Timer(TimeSpan.FromSeconds(splashScreenDuration))
                .Subscribe(_ => SceneManager.LoadSceneAsync((int) ScenesList.Game));
            //This code can be made from coroutine or by Invoke() method, but I always use UniRX
        }
    }
}