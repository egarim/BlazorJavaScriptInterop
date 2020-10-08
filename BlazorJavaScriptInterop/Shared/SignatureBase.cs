using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorJavaScriptInterop.Shared
{
    public class SignatureBase : ComponentBase
    {
        public SignatureBase()
        {
          
            this.ComponentModel = new SignatureModel();
            //this.ComponentModel.Data = File.ReadAllText("Signature.txt"); 
        }

        public SignatureModel ComponentModel { get; set; }
       
        [Inject]
        protected IJSRuntime JSRuntime { get; set; }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeAsync<object>("InitSignature", this.ComponentModel);
              

            }
        }
    }
}
