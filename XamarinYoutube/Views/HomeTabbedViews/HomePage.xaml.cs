using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinYoutube.Models;

namespace XamarinYoutube.Views.HomeTabbedViews
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            FillInfo();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            FillInfo();
        }

        void FillInfo()
        {
            List<YoutubeModel> youtubeModels = new List<YoutubeModel>();
            youtubeModels.Add(new YoutubeModel
            {
                VideoPicture = "https://i.ytimg.com/vi/ybji16u608U/hqdefault.jpg?sqp=-oaymwEZCNACELwBSFXyq4qpAwsIARUAAIhCGAFwAQ==&rs=AOn4CLB9cx2QjBjl-LBeb6LRnyQ6eXZ3yA",
                VideoProfileName = "Marvel Entertainment",
                VideoProfilePicture = "https://yt3.ggpht.com/a/AATXAJyIGMyiH1LXiGvakXx3Rlxso_ozkk2WPbJCiA=s288-c-k-c0xffffffff-no-rj-mo",
                VideoTitle = "Marvel Studios' Black Widow | Final Trailer",
                VideoSharingDay = "3 Hafta önce",
                VideoShownCount = "13 Mn",
                VideoTime = "2:25"
            });
            youtubeModels.Add(new YoutubeModel
            {
                VideoPicture = "eminem.jpg",
                VideoProfileName = "EminemMusic",
                VideoProfilePicture = "eminemprofile.jpg",
                VideoTitle = "Eminem - Lose Yourself",
                VideoSharingDay = "4 yıl önce",
                VideoShownCount = "834 Mn",
                VideoTime = "5:24"
            });
            youtubeModels.Add(new YoutubeModel
            {
                VideoPicture = "https://i.ytimg.com/vi/gITmRDRMgn8/hqdefault.jpg?sqp=-oaymwEZCNACELwBSFXyq4qpAwsIARUAAIhCGAFwAQ==&rs=AOn4CLBT7PLBHr4r3ph2H4aahKlYY01uNQ",
                VideoProfileName = "Fenerbahçe",
                VideoProfilePicture = "https://yt3.ggpht.com/a/AATXAJy4bf3RugfKfOiZN4ntNaLKaWd3vAH2mcu20Q=s288-c-k-c0xffffffff-no-rj-mo",
                VideoTitle = "Bizimkilerin Antremanı",
                VideoSharingDay = "1 Hafta önce",
                VideoShownCount = "57 Bn",
                VideoTime = "3:03"
            });
            youtubeModels.Add(new YoutubeModel
            {
                VideoPicture = "https://i.ytimg.com/vi/gG_dA32oH44/hqdefault.jpg?sqp=-oaymwEZCNACELwBSFXyq4qpAwsIARUAAIhCGAFwAQ==&amp;rs=AOn4CLBjhnu72VGm9NAjRecDPwgkJ9gXxg",
                VideoProfileName = "Jay-Z",
                VideoProfilePicture = "data:image/jpeg;base64,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",
                VideoTitle = "Jay-Z & Kanye West - Ni**as In Paris",
                VideoSharingDay = "8 Yıl önce",
                VideoShownCount = "282 Mn",
                VideoTime = "4:12"
            });
            
            
            listYoutubeVideos.BindingContext = youtubeModels;
        }

        void listYoutubeVideos_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            ListView lv = sender as ListView;
            lv.SelectedItem = null;
        }
    }
}
