using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinYoutube.Views.HomeTabbedViews;

namespace XamarinYoutube.Views
{
    public partial class HomeTabbedPage : TabbedPage
    {
        public HomeTabbedPage()
        {
            InitializeComponent();
            Children.Add(new HomePage());
            Children.Add(new DiscoverPage());
            Children.Add(new SubscriptionsPage());
            Children.Add(new InboxPage());
            Children.Add(new BookmarkPage());
        }
    }
}
