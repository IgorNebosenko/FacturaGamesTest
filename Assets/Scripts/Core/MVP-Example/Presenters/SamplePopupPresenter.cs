using System.Collections.Generic;
using CM.Core.MVP_Example.Views;
using ElectrumGames.MVP;
using ElectrumGames.MVP.Utils;

namespace CM.Core.MVP_Example.Presenters
{
    public class SamplePopupArgs : PopupArgs
    {
    }

    public class SamplePopupResult : PopupResult
    {
    }

    public class SamplePopupPresenter : PopupPresenterCoroutine<SamplePopup, SamplePopupArgs, SamplePopupResult>
    {
        public SamplePopupPresenter(SamplePopup view) : base(view)
        {
        }

        public override IEnumerable<SamplePopupResult> Init(SamplePopupArgs args)
        {
            throw new System.NotImplementedException();
        }
    }
}