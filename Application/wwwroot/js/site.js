// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function autoFilAddress() {
    let checkBox = document.getElementById('checkBox');

    let pAddressLine1 = document.getElementById("pAddressLine1");
    let pAddressLine2 = document.getElementById("pAddressLine2");
    let pZipcode = document.getElementById("pZipcode");
    let pCity = document.getElementById("pCity");
    let pState = document.getElementById("pState");
    let pCountry = document.getElementById("pCountry");

    let curAddressLine1 = document.getElementById("curAddressLine1");
    let curAddressLine2 = document.getElementById("curAddressLine2");
    let curZipcode = document.getElementById("curZipcode");
    let curCity = document.getElementById("curCity");
    let curState = document.getElementById("curState");
    let curCountry = document.getElementById("curCountry");

    if (checkBox.checked == true) {

        let pAddressLine1Value = pAddressLine1.value;
        let pAddressLine2Value = pAddressLine2.value;
        let pZipcodeValue = pZipcode.value;
        let pCityValue = pCity.value;
        let pStateValue = pState.value;
        let pCountryValue = pCountry.value;

        curAddressLine1.value = pAddressLine1Value;
        curAddressLine2.value = pAddressLine2Value;
        curZipcode.value = pZipcodeValue;
        curCity.value = pCityValue;
        curState.value = pStateValue;
        curCountry.value = pCountryValue;


    }
    else if (checkBox.checked == false) {
        curAddressLine1.value = "";
        curAddressLine2.value = "";
        curLandmark.value = "";
        curZipcode.value = "";
        curCity.value = "";
        curState.value = "";
        curCountry.value = "";
    }
}