﻿using System;
using Xamarin.Forms;

namespace StudentList
{
    public class App : Application
    {
        public App()
        {
            ElPasoHighSchool.Library.Init();

            MainPage = new StudentListPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}