
function ShowMessage(MessageText) {

    alert(MessageText);
}
function InitSignature(SignatureModel) {

   
  
    var canvas = document.querySelector("canvas");
    var DataArea = document.getElementById("DataArea");
    var SaveButton = document.getElementById("Save");
    var ClearButton = document.getElementById("Clear");
    ClearButton.addEventListener("click", function () {
        signaturePad.clear();
    });
    SaveButton.addEventListener("click", function () {

        try {
            //TODO this only save the last changes, lets check the documentation later
            DataArea.value = signaturePad.toDataURL("image/svg+xml");
            console.debug(DataArea.value);
            //HACK this is how you trigger on change in a html element, to update the c# values bound to the component
            var event = new Event('change');
            // Dispatch it.
            DataArea.dispatchEvent(event);

      
        } catch (e) {
            alert(e);
        }
      
    });
    //var signaturePad = new SignaturePad(canvas);
    var signaturePad = new SignaturePad(canvas, {
        minWidth: 5,
        maxWidth: 10,
        penColor: "rgb(66, 133, 244)"
    });
    if (SignatureModel.data != "") {
        signaturePad.fromDataURL(SignatureModel.data)
    }
   
  


}