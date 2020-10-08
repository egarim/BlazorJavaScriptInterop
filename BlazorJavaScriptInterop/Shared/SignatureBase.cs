using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorJavaScriptInterop.Shared
{
    public class SignatureBase : ComponentBase
    {
        public SignatureBase()
        {
            this.ComponentModel = new SignatureModel();
        }
        private async Task Clear(MouseEventArgs e)
        {
            //Shipment = this.readUnitOfWork.Query<ShipmentBase>().FirstOrDefault(f => f.Code == this.Code);
            //if (Shipment != null)
            //{
            //    await SetStatus(Shipment.Status);
            //}

        }
        private async Task Update(MouseEventArgs e)
        {
            //Shipment = this.readUnitOfWork.Query<ShipmentBase>().FirstOrDefault(f => f.Code == this.Code);
            //if (Shipment != null)
            //{
            //    await SetStatus(Shipment.Status);
            //}

        }
        public SignatureModel ComponentModel { get; set; }
        //[Parameter] public SignatureModel ComponentModel { get; set; }
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
