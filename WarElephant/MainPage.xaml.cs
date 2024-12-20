using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WarElephant.Services;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.WindowManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WarElephant
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
			InitializeComponent();
			WindowHelper.Initialize(AppTitleBar, AppTitle);
			AppNavigation.SelectedItem = AppNavigation.MenuItems[0];
		}

		private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			AppTitleBar.Height = 50;
			AppTitleBar.Height = 48;
		}
	}
}
