using System.Windows.Controls;
using TimesheetTrackerVM.Menu;

namespace TimesheetTrackerWPF.Controls
{
    /// <summary>
    /// Interaction logic for MenuBarCtrl.xaml
    /// </summary>
    public partial class MenuBarCtrl : UserControl
    {
        #region Private Fields

        private MenuBarVM vm;

        #endregion Private Fields

        #region Public Constructors

        public MenuBarCtrl()
        {
            DataContext = vm = new MenuBarVM();
            InitializeComponent();
            SubscribeButtonsEvents();
        }

        #endregion Public Constructors

        #region Private Methods

        private void SubscribeButtonsEvents()
        {
            btnOpenMenu.Click += (s, a) => vm.IsMenuExpanded = true;
            btnCloseMenu.Click += (s, a) => vm.IsMenuExpanded = false;
        }

        #endregion Private Methods
    }
}