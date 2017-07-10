﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Loyals.Models;

namespace Loyals.Pages
{
    public class FirstPage : ContentPage
    {

        public FirstPage()
        {
            Label header = new Label()
            {
                Text = "ListView",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };


            List<Business> businesses = new List<Business>()
            {
                new Business("Zing Cafe", new DateTime(2017, 5, 15)),

                new Business("La Petite Hair Salon", new DateTime(2017, 5, 16))
            };


            ListView listView = new ListView
            {
                // Source of data items.
                ItemsSource = businesses,
                //ItemTemplate need to set to data template of view cell
            };

            Button checkPointsButton = new Button { Text = "Check Points" };

            //When you are in the the constructor, you have an instance of that class (first page)

            var newLayoutInstance = new StackLayout();
            newLayoutInstance.Children.Add(header);
            newLayoutInstance.Children.Add(listView);
            newLayoutInstance.Children.Add(checkPointsButton);

            Content = new StackLayout()
            {
                Children =
                {
                    header,
                    listView,
                    checkPointsButton
                }
            };
        }

        public class BusinessViewCell : ViewCell
        {
            public BusinessViewCell()
            {
				var myTextProperty = new Label() { Text = "Text" };
				var myDetailProperty = new Label() { Text = "Details" };

                var textStack = new StackLayout
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    Orientation = StackOrientation.Horizontal,
                    Children =
                    {

                    }
                };
            }
        }



	}
}
