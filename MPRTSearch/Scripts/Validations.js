function IsSearchTextEmpty() {
    if (document.getElementById('SearchText').value == "") {
        return 'sökord bör inte vara tomt';
    }
    else { return ""; }
}


function IsValid() {

    var SearchTextEmptyMessage = IsSearchTextEmpty();
    //var FirstNameInValidMessage = IsFirstNameInValid();
    //var LastNameInValidMessage = IsLastNameInValid();
    //var SalaryEmptyMessage = IsSalaryEmpty();
    //var SalaryInvalidMessage = IsSalaryInValid();

    var FinalErrorMessage = "Errors:";
    if (SearchTextEmptyMessage != "")
        FinalErrorMessage += "\n" + SearchTextEmptyMessage;
    //if (FirstNameInValidMessage != "")
    //    FinalErrorMessage += "\n" + FirstNameInValidMessage;
    //if (LastNameInValidMessage != "")
    //    FinalErrorMessage += "\n" + LastNameInValidMessage;
    //if (SalaryEmptyMessage != "")
    //    FinalErrorMessage += "\n" + SalaryEmptyMessage;
    //if (SalaryInvalidMessage != "")
    //    FinalErrorMessage += "\n" + SalaryInvalidMessage;

    if (FinalErrorMessage != "Errors:") {
        alert(FinalErrorMessage);
        return false;
    }
    else {
        return true;
    }
}