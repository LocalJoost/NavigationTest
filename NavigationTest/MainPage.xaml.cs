using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NavigationTest
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainPage : Page
  {
    public MainPage()
    {
      this.InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
      base.OnNavigatedTo(e);
      var rootFrame = Window.Current.Content as Frame;
      if (rootFrame != null)
      {
        SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = rootFrame.CanGoBack
          ? AppViewBackButtonVisibility.Visible
          : AppViewBackButtonVisibility.Collapsed;
      }
    }

    private void Navigation_Click(object sender, RoutedEventArgs e)
    {
      // Uncomment line below to make navigation work from a SplitView as well.
      //rootSplitView.IsPaneOpen = false;
      Frame rootFrame = Window.Current.Content as Frame;
      rootFrame.Navigate(typeof(Page2));
    }

    private void Hamburger_Click(object sender, RoutedEventArgs e)
    {
      rootSplitView.IsPaneOpen = true;
    }
  }
}
