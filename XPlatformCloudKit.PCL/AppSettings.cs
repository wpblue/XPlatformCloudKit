/*
* LICENSE: https://raw.github.com/apimash/StarterKits/master/LicenseTerms-SampleApps%20.txt
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPlatformCloudKit.DataServices;
using XPlatformCloudKit.Models;

namespace XPlatformCloudKit
{
    /// <summary>
    /// Public singleton class for storing application-wide settings
    /// </summary>
    public static class AppSettings
    {
        #region Global Options
        //The name of your applicaion, this value appears at the top of your app
        public static string ApplicationName = "Everybody Loves Raymond";

        //Timeframe in minutes to store data before making new request to Data Source
        //set to negative value to disable caching
        public const int CacheIntervalInMinutes = 60;
        #endregion

        #region AzureMobileService Settings
        public const bool EnableAzureMobileService = false;  //Use Mobile Service located @ MobileServiceAddress with Key set to MobileServiceApplicationKey

        //Mark true to create the Initial Schema if you are running for the first time against a brand new Mobile Service
        //Be sure you have created a table named "Item" and have permission to update with app key
        //After running once, set back to false
        public const bool CreateInitialSchemaForAzureMobileService = false;

        //Your Azure Mobile Service Address 
        //i.e. https://xplatformcloudkit.azure-mobile.net/
        public const string MobileServiceAddress = "https://xplatformcloudkit.azure-mobile.net/";

        //You Azure Mobile Service Key 
        //i.e. UYZnUrrabofKBELSRdRsmCGboyDGMJ15
        public const string MobileServiceApplicationKey = "UYZnUrrabofKBELSRdRsmCGboyDGMJ15";

        #endregion

        #region RssService Settings
        public const bool EnableRssService = true;//Use RssAddressCollection 
        public const int RssMaxItemsPerFeed = -1; //The Maximum number of items to fetch for each feed. Enter Negative value to fetch all.

        //Urls to an RSS Data Source 
        //i.e. http://reddit.com/r/technology/.rss
        // NOTE: Make sure that the Group value you use is longer than 1 character or a name will be autogenerated from the RSS data.
        public static readonly RssSource[] RssAddressCollection = 
        {
            new RssSource{Url = "http://gdata.youtube.com/feeds/api/playlists/PLA2DwF0lv8z8ecsqCbQ6CgsKLzUedhUK0?alt=rss&max-results=50&start-index=1", Group = "Season 1"},
            //new RssSource{Url = "https://www.facebook.com/feeds/page.php?format=rss20&id=487598667939827", Group = "Facebook Example"},
            //new RssSource{Url = "http://api.flickr.com/services/feeds/photos_public.gne?format=rss&tags=cats", Group = "Flickr Example"},
            //new RssSource{Url = "http://pipes.yahoo.com/pipes/pipe.run?_id=74fc14a798efee89310bea2b56f99336&_render=rss&n=10", Group = "Yahoo Pipes example"},
            //new RssSource{Url = "http://gdata.youtube.com/feeds/base/videos?alt=rss&q=xbox%20one", Group = "Youtube query example"},
            //new RssSource{Url = "http://gdata.youtube.com/feeds/base/videos?alt=rss&author=thewindotnet", Group = "Youtube author example"},
            //new RssSource{Url = "http://www.amazon.com/rss/tag/xbox/new/", Group = "Amazon example"},
            //new RssSource{Url = "http://reddit.com/r/Microsoft/.rss", Group = "Reddit example"},
            //new RssSource{Url = "http://www.bing.com/search?q=tesla&format=rss", Group = "Bing example"},
            //new RssSource{Url = "http://changelogshow.com/105.rss", Group = "Podcast example"},
            //new RssSource{Url = "http://blog.designersofthings.com/rss", Group = "Tumblr Example"},
            //new RssSource{Url = "http://pinterest.com/happylynnifer/feed.rss", Group = "Pinterest User Example"},
            //new RssSource{Url = "http://www.pinterest.com/happylynnifer/human-tech-advances.rss", Group = "Pinterest User Board Example"},
        };

        /*
         * Put the URL to a file on a web server you control that will contain a list of additional RSS
         *  feeds you want to add to the list of feeds in RssAddressCollection below.  The file should
         *  be a simple CSV file containing two fields per line, with the fields separate by a comma.
         *  The first field should be a valid RSS URL and the second field should be the group name
         *  you want the feed assigned to.
         *
         * Here's an example of a sample remote RSS feed file with two YouTube channels, and a single common group.
         * 
         *  https://gdata.youtube.com/feeds/api/users/TheWindotnet/uploads?orderby=updated&alt=rss, "Remote RSS Feed Example"
         *  https://gdata.youtube.com/feeds/api/users/roschler/uploads?orderby=updated&alt=rss, "Remote RSS Feed Example"
         *
         * Make sure EnableRssService to set to TRUE or the remote content (or the RSS feeds below) will 
         *  not be accessed.  Leave RemoteRssSourceUrl blank if you do not want to use the remote RSS
         *  feature.
         */
        //The value below can be used to test RemoteRssSourceUrl, but please don't leave it active in your published app.
        //public const string RemoteRssSourceUrl = "http://robodance.com/xplatformcloudkit/remote-rss-feed-sample.txt";
        public const string RemoteRssSourceUrl = "";

        #endregion

        #region LocalItemsFileService Settings
        public const bool EnableLocalItemsFileService = false; //Use Items contained in LocalItemsFile.xml
        //This allows users to host a remote XML file for their items. You can use http://ualr.edu/adcrow/XPCKItemFiles/TestItemsFile.xml as a test.
        public const string RemoteItemFileService = "";
        #endregion

        #region Windows8 Project options
        //Items whose Group Name is contained in the following Dictionary will display their Description field in full screen
        //When an item of this group is selected, it will not show it's Title, Subtitle, or Image. (Ideal for Youtube RSS feeds)
        public static readonly string[] GroupsToDisplayInFullScreen = 
        {
            "Youtube Playlist Example","Youtube query example"
        };

        //Determines whether to use the Light theme (white background / black text) over the default Dark theme
        //(black background / white text)
        public const bool UseLightThemeForWindows8 = true;
        //To change specifics value of the chosen theme, i.e. Font Color throughout the Windows 8 application
        //Open XPlatformCloudKit.Win8/Common/StandardStyles.xaml and look for the <!-- Theme Overrides --> Section
        //Uncomment the portion(s) of the theme you wish to override

        //Determines whether a background image should be used in the Windows 8 app.
        //Set to false to use standard theme. Set to true to use wallpaper. To change the wall paper, replace Wallpaper.png in the Assets folder.
        public const bool EnableWin8Background = false;

        //Url to your privacy policy - default value is "http://pjdecarlo.com/2013/11/app-privacy-policy.html"
        //Note: This is REQUIRED for certification in the Windows 8 store
        public const string PrivacyPolicyUrl = "http://pjdecarlo.com/2013/11/app-privacy-policy.html";
        #endregion

        #region Windows Phone 8 Project options      
        //Set to true if you wish to employ a trial experience when submitting your app to the marketplace
        public const bool TrialModeEnabled = false;
        //Use to test app behavior as though Trial Mode has been enabled in the marketplace, SET TO FALSE BEFORE SUBMITTING TO MARKETPLACE
        public const bool SimulateTrialMode = false;
        //The amount of days to run the app unrestriced if Trial Mode is enforced, Set to negative value to simulate expiration
        public const int TrialPeriodInDays = 7;

        //Determines whether a background image should be used in the Windows Phone 8 app.
        //Set to false to use standard theme. Set to true to use wallpaper. To change the wall paper, replace Wallpaper.png in the Assets folder.
        public const bool EnablePhone8Background = false;

        //Enables logic for discovery of phone numbers present in Item.Description on the ItemDescriptionView
        //Creates a button for all discovered numbers that when clicked, initiates a phone call (Only works on physical device)
        //Examples of matching formats: (123) 123-1234 ; 800-555-1212
        public const bool EnableParsingPhoneNumbersPhone8 = true;
        #endregion

        #region Youtube Video Link Options
        //Forces Youtube links to be rewritten so that they load the video only in full screen
        //This produces a very clean look as the related videos etc. are not visible
        public const bool ForceYoutubeVideosToLoadFullScreen = true;

        //When a Youtube Video link exists for an item it will begin playing that video when the item is selected
        //This will only Display the Youtube video, all other data in the description is ignored - Effects Win8 only
        public const bool AutoPlayYoutubeVideos = true;
        #endregion

        #region Advanced ItemDescriptionView / Webview Options for Windows 8 and Windows Phone projects
        //Determines background color of WebView Control used behind Description in ItemDescriptionView.xaml.cs
        //Set to "Auto" to determine based on theme background or override using hex color string i.e. "#FFFFFF" for white, "#000000" for black
        public const string BackgroundColorOfDescription = "Auto";

        //Determines Font color of WebView Control used to display Description in ItemDescriptionView.xaml.cs
        //Set to "Auto" to determine based on theme background or override using hex color string i.e. "#FFFFFF" for white, "#000000" for black
        public const string FontColorOfDescription = "Auto";


        //Determines whether hyperlinks can be clicked in ItemDescriptionView.xaml for both Windows 8 and Windows Phone 8 projects
        //Sometimes, store may fail apps which contain hyperlinks that navigate improperly when clicked, this disables them
        public const bool DisableHyperLinksInItemDescriptionView = false;

        //Determines whether hyperlinks with target="_blank" are rewritten to target="_self"
        //When enabled, hyperlinks will not open in a new tab
        public const bool DisableOpeningHyperLinksInNewTab = true;
        #endregion

        #region App Promo Options for Windows 8 and Windows Phone projects
        //App Promo is a control created by Jared Bienz which provides a rating reminder to users based on user defined settings
        //http://code.msdn.microsoft.com/wpapps/Improve-app-ratings-with-a-6139caa5
        public const bool EnableAppPromoRatingReminder = true;
        
        //The number of application runs before the reminder will be displayed. The default is 7.
        public const int NumberOfRunsBeforeRateReminder = 7;

        #endregion

        #region Advertising Control Options for Windows 8 and Windows Phone projects
        //Allow displaying of Ads from Microsoft Pubcenter in Windows Phone 8 Project
        //http://msdn.microsoft.com/en-us/library/advertising-mobile-windows-phone-sdk(v=msads.20).aspx
        public const bool EnablePubcenterAdsPhone8 = false;
        //Should Ads be hidden if the app has been purchased  (true) or always shown (false) 
        public const bool HideAdsIfPurchasedPhone8 = false;
        //Application and AdUnit Ids provided from Pubcenter
        //See: http://msdn.microsoft.com/en-us/library/advertising-mobile-windows-phone-sdk-start(v=msads.20).aspx
        //for information on configuring and providing your own ads
        //Supports 480x80 ads only!  Make sure your add unit matches this size when creating in Pubcenter!
        public const string PubcenterApplicationIdPhone8 = "test_client";
        public const string PubcenterAdUnitIdPhone8 = "Image480_80";

        //Allow displaying of Ads from Microsoft Pubcenter in Windows 8 Project
        //http://msdn.microsoft.com/en-us/library/advertising-windows-sdk(v=msads.10).aspx
        public const bool EnablePubcenterAdsWin8 = false;
        //Should Ads be hidden if the app has been purchased  (true) or always shown (false) 
        public const bool HideAdsIfPurchasedWin8 = false;
        //Application and AdUnit Ids provided from Pubcenter
        //See: http://msdn.microsoft.com/en-us/library/advertising-windows-pubcenter(v=msads.10).asp
        //for information on configuring and providing your own ads
        //Supports 728x90 ads only!  Make sure your add unit matches this size when creating in Pubcenter!
        //Be careful your ad does not block your Application Title!  To change the render size see lines 65 & 66 of XPlatformCloudKit.Win8/Views/ItemsShowcaseView.xaml.cs
        public const string PubcenterApplicationIdWin8 = "d25517cb-12d4-4699-8bdc-52040c712cab";
        public const string PubcenterAdUnitIdWin8 = "10042999";
        #endregion
    }
}
