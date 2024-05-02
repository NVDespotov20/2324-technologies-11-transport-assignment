using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRental.PL.Views
{
    public partial class MainMenuView : UserControl
    {
        public event EventHandler<MainMenuEventArgs> MainMenuButtonClicked;


        public MainMenuView()
        {
            InitializeComponent();
        }

        private void signInButton_Click_1(object sender, EventArgs e)
        {
            MainMenuButtonClicked?.Invoke(this, new MainMenuEventArgs(MainMenuButtonType.SignIn));
        }

        private void registerButton_Click_1(object sender, EventArgs e)
        {
            MainMenuButtonClicked?.Invoke(this, new MainMenuEventArgs(MainMenuButtonType.Register));
        }

        public enum MainMenuButtonType
        {
            SignIn,
            Register
        }

        // Custom EventArgs class to include information about the button click
        public class MainMenuEventArgs : EventArgs
        {
            public MainMenuButtonType ButtonType { get; }

            public MainMenuEventArgs(MainMenuButtonType buttonType)
            {
                ButtonType = buttonType;
            }
        }
    }
}
