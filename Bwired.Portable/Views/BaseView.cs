﻿using Bwired.ViewModels;
using Xamarin.Forms;

namespace Bwired.Views
{
    public class BaseView : ContentPage
    {
        public BaseView()
        {
            SetBinding(Page.TitleProperty, new Binding(BaseViewModel.TitlePropertyName));
            SetBinding(Page.IconProperty, new Binding(BaseViewModel.IconPropertyName));
        }
    }
}

