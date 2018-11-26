using System;
using System.Windows;

namespace BandcampDownloader {

    public class SkinResourceDictionary: ResourceDictionary {
        private Uri darkSource;

        public Uri DarkSource {
            get {
                return darkSource;
            }
            set {
                darkSource = value;
                UpdateSource();
            }
        }

        private void UpdateSource() {
            switch (App.Skin) {
                case Skin.Dark:
                    if (DarkSource != null) {
                        base.Source = DarkSource;
                    }
                    break;
                case Skin.Light:
                    break;
                default:
                    break;
            }
        }
    }
}