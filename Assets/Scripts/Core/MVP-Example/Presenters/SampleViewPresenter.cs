using CM.Core.MVP_Example.Views;
using ElectrumGames.MVP;

namespace CM.Core.MVP_Example.Presenters
{
    public class SampleViewPresenter : Presenter<SampleView>
    {
        public SampleViewPresenter(SampleView view) : base(view)
        {
        }
    }
}