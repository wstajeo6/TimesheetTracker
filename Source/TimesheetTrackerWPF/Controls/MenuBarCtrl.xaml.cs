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
            InitializeComponent();
            SubscribeButtonsEvents();
            DataContext = vm = new MenuBarVM();
        }

        #endregion Public Constructors

        #region Private Methods

        private void SubscribeButtonsEvents()
        {
            //btnOpenMenu.Click += (s, a) => vm.IsMenuCollapsed = false;
            //btnCloseMenu.Click += (s, a) => vm.IsMenuCollapsed = true;
        }

        #endregion Private Methods
    }
}