using System;
using System.Linq;

namespace BlazorJavaScriptInterop.Shared
{
    public class SignatureData :  ComponentModel,ISignature
    {

        public SignatureData()
        {

        }

        string data;

        public string Data
        {
            get => data;
            set => SetPropertyValue<string>(ref data, value, nameof(Data));
        }
        

    }
}
