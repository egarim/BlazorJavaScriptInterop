using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BlazorJavaScriptInterop.Shared
{
    public class SignatureModel : MyComponentModel
    {


        public SignatureModel()
        {
           
        }
        protected override void OnPropertyChanged(string propertyName,object value)
        {
            File.WriteAllText("Signature.txt", value.ToString());
            base.OnPropertyChanged(propertyName, value);
        }
        string data;

        public string Data
        {
            get => GetPropertyValue<string>(ref data);
            set => SetPropertyValue<string>(ref data, value, nameof(Data));
        }
        

    }
}
