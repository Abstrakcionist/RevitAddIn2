using Proj.ViewModels;

namespace Proj.Views;

public sealed partial class ProjView
{
    public ProjView(ProjViewModel viewModel)
    {
        DataContext = viewModel;
        InitializeComponent();
    }
}