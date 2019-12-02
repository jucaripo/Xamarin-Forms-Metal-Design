using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace metaldesign
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Application.Current.Resources["NavigationPrimary"] = Application.Current.Resources["MdPrimaryColor"];


        }
    }
}
