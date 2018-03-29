﻿using System;
using System.ComponentModel;
using MovieApp.Services;
using MovieApp.ViewModels;
using MovieApp.Views;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;
using Unity;
using Xamarin.Forms;

namespace MovieApp
{
	public partial class App : PrismApplication
    {

		public App ()
		{
			InitializeComponent();

            MainPage = new MainPage();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MovieListPage>();
            containerRegistry.RegisterForNavigation<MovieDetailPage>();

            containerRegistry.Register<ITheMovieDbApi, TheMovieDbApi>();
            containerRegistry.Register<IMovieService, MovieService>();
        }

        protected override void OnInitialized()
        {
        }
    }
}
