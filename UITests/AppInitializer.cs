﻿using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp

                     .Android
                     .InstalledApp("com.companyname.rayshotdogs")
                     .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

