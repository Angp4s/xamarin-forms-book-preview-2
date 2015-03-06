﻿using System;
using Xamarin.Forms;

namespace BasicStyleCode
{
    public class BasicStyleCodePage : ContentPage
    {
        public BasicStyleCodePage()
        {
            Resources = new ResourceDictionary
            {
                { "buttonStyle", new Style(typeof(Button))
                    {
                        Setters = 
                        {
                            new Setter
                            {
                                Property = View.HorizontalOptionsProperty,
                                Value = LayoutOptions.Center
                            },
                            new Setter 
                            {
                                Property = View.VerticalOptionsProperty,
                                Value = LayoutOptions.CenterAndExpand
                            },
                            new Setter
                            {
                                Property = Button.BorderWidthProperty,
                                Value = 3
                            },
                            new Setter
                            {
                                Property = Button.TextColorProperty,
                                Value = Color.Red
                            },
                            new Setter
                            {
                                Property = Button.FontSizeProperty,
                                Value = Device.GetNamedSize(NamedSize.Large, typeof(Button))
                            }
                        }
                    }
                }
            };

            Content = new StackLayout
            {
                Children = 
                {
                    new Button
                    {
                        Text = " Do this! ",
                        Style = (Style)Resources["buttonStyle"]
                    },
                    new Button
                    {
                        Text = " Do that! ",
                        Style = (Style)Resources["buttonStyle"]
                    },
                    new Button
                    {
                        Text = " Do the other thing! ",
                        Style = (Style)Resources["buttonStyle"]
                    }
                }
            };
        }
    }
}
