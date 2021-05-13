using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Umler.Models;

namespace Umler.ViewModels
{
    public class PropertiesControlViewModel : BindableBase, INavigationAware
    {
        private BaseModel _selected;
        public BaseModel Selected 
        { 
            get => _selected;
            set
            {
                SetProperty(ref _selected, value);
                FillProperties();
            }
        }


        private IList<KeyValuePair<string, string>> _properties;
        public IList<KeyValuePair<string, string>> Properties 
        { 
            get => _properties; 
            set => SetProperty(ref _properties, value);
        }

        public PropertiesControlViewModel()
        {
            //Selected = selected ?? throw new ArgumentNullException(nameof(selected));
            Properties = new List<KeyValuePair<string, string>>();
        }

        private void FillProperties()
        {
            var container = ViewsAccessibility.GetCorresponingWindow(this);

            Properties.Clear();
            if (Selected == null)
            {
                return;
            }

            var instance = Selected;// Activator.CreateInstance(Selected);
            var allProperties = Selected.GetType().GetProperties();

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            Selected = navigationContext.Parameters.GetValue<BaseModel>("selected");
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
    }


    public static class ViewsAccessibility
    {
        public static Window GetCorresponingWindow(BindableBase viewModel)
        {
            var windowAccessibility = new WindowAccessibility(viewModel);
            return windowAccessibility.CorrespondanteWindow;
        }

        private class WindowAccessibility
        {
            public Window CorrespondanteWindow { get; private set; }

            public WindowAccessibility(BindableBase viewModel)
            {
                var windows = Application.Current.Windows.OfType<Window>();
                CorrespondanteWindow = (from window in windows
                                        where window.DataContext.Equals(viewModel)
                                        select window).FirstOrDefault();
            }
        }


    
    }
}
