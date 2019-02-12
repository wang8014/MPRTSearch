function IsSearchTextEmpty() {
    if (document.getElementById('SearchText').value == "") {
        return 'sökord bör inte vara tomt';
    }
    else { return ""; }
}
function IsSearchTextSpace() {
    if (document.getElementById('SearchText').value.length > 0) {
        if (document.getElementById('SearchText').value.trim() == "") {
            return 'sökord bör inte bara vara mellanslag';
        }
        else { return ""; }
    } else { return ""; }
 
}

function IsValid() {

    var SearchTextEmptyMessage = IsSearchTextEmpty();
    var SearchTextSpaceMessage = IsSearchTextSpace();
    //var LastNameInValidMessage = IsLastNameInValid();
    //var SalaryEmptyMessage = IsSalaryEmpty();
    //var SalaryInvalidMessage = IsSalaryInValid();

    var FinalErrorMessage = "";
    if (SearchTextEmptyMessage != "")
        FinalErrorMessage += "\n" + SearchTextEmptyMessage;
    if (SearchTextSpaceMessage != "")
        FinalErrorMessage += "\n" + SearchTextSpaceMessage;
    //if (LastNameInValidMessage != "")
    //    FinalErrorMessage += "\n" + LastNameInValidMessage;
    //if (SalaryEmptyMessage != "")
    //    FinalErrorMessage += "\n" + SalaryEmptyMessage;
    //if (SalaryInvalidMessage != "")
    //    FinalErrorMessage += "\n" + SalaryInvalidMessage;
    if (FinalErrorMessage.trim().length > 0) {
        FinalErrorMessage = "Errors:"
    }
    return FinalErrorMessage;
    //if (FinalErrorMessage != "Errors:") {
    //    alert(FinalErrorMessage);
    //    return FinalErrorMessage;
    //}
    //else {
    //    return FinalErrorMessage;
    //}
}