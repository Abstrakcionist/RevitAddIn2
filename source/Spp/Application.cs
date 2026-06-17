using Nice3point.Revit.Extensions.UI;
using Nice3point.Revit.Toolkit.External;
using Spp.Commands;

namespace Spp;

/// <summary>
///     Application entry point
/// </summary>
[UsedImplicitly]
public class Application : ExternalApplication
{
    public override void OnStartup()
    {
        CreateRibbon();
    }

    private void CreateRibbon()
    {
        var panel = Application.CreatePanel("Commands", "Spp");

        panel.AddPushButton<StartupCommand>("Execute")
            .SetImage("/Spp;component/Resources/Icons/RibbonIcon16.png")
            .SetLargeImage("/Spp;component/Resources/Icons/RibbonIcon32.png");
    }
}