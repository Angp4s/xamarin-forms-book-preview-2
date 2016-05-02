﻿using System;
using System.IO;
using System.Net;
using System.Reflection;
using Xamarin.Forms;

namespace BitmapStreams
{
    public partial class BitmapStreamsPage : ContentPage
    {
        public BitmapStreamsPage()
        {
            InitializeComponent();

            // Load embedded resource bitmap.
            string resourceID = "BitmapStreams.Images.IMG_0722_512.jpg";
            image1.Source = ImageSource.FromStream(() => 
                {
                    Assembly assembly = GetType().GetTypeInfo().Assembly;
                    Stream stream = assembly.GetManifestResourceStream(resourceID);
                    return stream;
                });

            // Load web bitmap.
            Uri uri = new Uri("https://developer.xamarin.com/demo/IMG_0925.JPG?width=512");
            WebRequest request = WebRequest.Create (uri);
            request.BeginGetResponse((IAsyncResult arg) =>
                {
                    Stream stream = request.EndGetResponse(arg).GetResponseStream();
                    ImageSource imageSource = ImageSource.FromStream(() => stream);
                    Device.BeginInvokeOnMainThread(() => image2.Source = imageSource);
                }, null);
        }
    }
}
