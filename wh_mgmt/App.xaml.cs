using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace wh_mgmt {
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application {
    
    protected override void OnStartup(StartupEventArgs e) {
      base.OnStartup(e);
      view.BrowseWindow window = new view.BrowseWindow();
      viewModel.whdocBrowseViewModel VM = new viewModel.whdocBrowseViewModel();
      window.DataContext = VM;
      window.Show();
    }
    
  }
}
