using System.Windows;

namespace BandcampDownloader {

    public enum Skin { Dark, Light }

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App: Application {
        public static Skin Skin { get; set; } = Skin.Dark;
    }
}