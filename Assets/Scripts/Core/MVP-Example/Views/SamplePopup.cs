using CM.Core.MVP_Example.Presenters;
using ElectrumGames.MVP;

namespace CM.Core.MVP_Example.Views
{
    [AutoRegisterView(customPath: "Views/Popups/SamplePopup")]
    public class SamplePopup : View<SamplePopupPresenter>
    {
        
    }
}