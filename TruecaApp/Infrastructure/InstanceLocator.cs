﻿using TruecaApp.ViewModels;

namespace TruecaApp.Infrastructure
{
    
    public class InstanceLocator
    {
		public MainViewModel Main
		{
			get;
			set;
		}

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
