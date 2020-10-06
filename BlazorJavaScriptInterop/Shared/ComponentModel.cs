using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BlazorJavaScriptInterop.Shared
{
    public class ComponentModel : INotifyPropertyChanged, IDisposable
    {
        private string name;
        private string cssClass;
        private PropertyChangedEventHandler propertyChanged;
        private readonly Dictionary<string, object> attributes = new Dictionary<string, object>();
        [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters")]
        protected T GetPropertyValue<T>(ref T propertyValue, [CallerMemberName] string propertyName = null)
        {
            return propertyValue;
        }
        protected bool SetPropertyValue<T>(ref T propertyValue, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(propertyValue, newValue))
            {
                return false;
            }
            propertyValue = newValue;
            OnPropertyChanged(propertyName);
            return true;
        }
        protected void OnPropertyChanged(string propertyName)
        {
            propertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add { propertyChanged += value; }
            remove { propertyChanged -= value; }
        }
        public IReadOnlyDictionary<string, object> Attributes => attributes;
        public void SetAttribute(string name, object value)
        {
            attributes[name] = value;
            OnPropertyChanged(name);
        }
        public bool IsDisposed { get; private set; }
        public void Dispose()
        {
            IsDisposed = true;
        }
        public string Name
        {
            get { return GetPropertyValue(ref name); }
            set { SetPropertyValue(ref name, value); }
        }
        public string CssClass
        {
            get { return GetPropertyValue(ref cssClass); }
            set { SetPropertyValue(ref cssClass, value); }
        }
    }
}
