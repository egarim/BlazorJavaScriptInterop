using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BlazorJavaScriptInterop.Shared
{
    public class SignatureModel 
    {


        public SignatureModel()
        {
            this.Signature = new SignatureData();
        }
        public string Data
        {
            get => this.Signature.Data;
            set
            {
                this.Signature.Data = value;
            }
        }
        ISignature Signature;
        public void SetData(ISignature Signature)
        {
            this.Signature = Signature;
        }

    }
}
