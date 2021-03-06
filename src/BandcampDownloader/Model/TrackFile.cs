﻿using System;

namespace BandcampDownloader {

    internal class TrackFile {
        public long BytesReceived { get; set; }
        public Boolean Downloaded { get; set; }
        public long Size { get; set; }
        public String Url { get; set; }

        public TrackFile(String url, long bytesReceived, long size) {
            Url = url;
            BytesReceived = bytesReceived;
            Size = size;
        }
    }
}