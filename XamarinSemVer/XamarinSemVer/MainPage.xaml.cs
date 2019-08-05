using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinSemVer
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var sb = new StringBuilder();

            // First time ever launched application
            var firstLaunch = VersionTracking.IsFirstLaunchEver;
            sb.AppendLine($"First launch ever {firstLaunch}");

            // Current app version
            var currentVersion = VersionTracking.CurrentVersion;
            sb.AppendLine($"Current version {currentVersion}");

            // First time launching current version
            var firstLaunchCurrent = VersionTracking.IsFirstLaunchForCurrentVersion;
            sb.AppendLine($"First launch current version {firstLaunchCurrent}");

            // Current build
            var currentBuild = VersionTracking.CurrentBuild;
            sb.AppendLine($"Current build {currentBuild}");

            // First time launching current build
            var firstLaunchBuild = VersionTracking.IsFirstLaunchForCurrentBuild;
            sb.AppendLine($"First launch current build {firstLaunchBuild}");

            // Previous app version
            var previousVersion = VersionTracking.PreviousVersion;
            sb.AppendLine($"Previous version {previousVersion}");

            // Previous app build
            var previousBuild = VersionTracking.PreviousBuild;
            sb.AppendLine($"Previous build {previousBuild}");

            // First version of app installed (1.0.0)
            var firstVersion = VersionTracking.FirstInstalledVersion;
            sb.AppendLine($"First installed version {firstVersion}");

            // First build of app installed
            var firstBuild = VersionTracking.FirstInstalledBuild;
            sb.AppendLine($"First installed build {firstBuild}");

            // List of versions installed (1.0.0, 2.0.0)
            var versionHistory = VersionTracking.VersionHistory;
            sb.AppendLine($"All installed versions {String.Join(", ", versionHistory)}");

            // List of builds installed (1, 2)
            var buildHistory = VersionTracking.BuildHistory;
            sb.AppendLine($"All installed builds {String.Join(", ", buildHistory)}");

            Label.Text = sb.ToString();
        }
    }
}
