﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace DiscountLocator19
{
    public class CurrentActivity
    {
        private static AppCompatActivity activity;

        public static void setActivity(AppCompatActivity activity)
        {
            CurrentActivity.activity = activity;
        }

        public static AppCompatActivity getActivity()
        {
            return activity;
        }
    }
}