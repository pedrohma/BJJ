$(document).ready(function() {
        $("#signUpForm").hide();
});

function goToSignUp()
{
    $("#login").hide();
    $("#signUpForm").show();
}

function goToLogin()
{
    $("#signUpForm").hide();
    $("#login").show();
}

function login()
{
    var login = $("#login").val();
    var passwordLogin = $("#passwordLogin").val();
    alert('login: ' + login);
}

function signUp(){
    var data = setAcademyToJSON();
    $.ajax({         type: "POST",         url: location.protocol + '//' + location.host + "/Home/SignUp/",         contentType: "application/json; charset=utf-8",         data: data,         dataType: "json",         success: function (msg) {                     },         error: function (req, status, error) {             //alert('error:' + error);         }     }); 
}

function setAcademyToJSON() {
    var academyName = $("#academyName").val();
    var academyEmail = $("#academyEmail").val();
    var password = $("#password").val();
    var street = $("#street").val();
    var zipCode = $("#zipCode").val();
    var country = $("#country").val();
    var country = {Country: country};
    var address = {Street: street, ZipCode: zipCode};
    var academy = {AcademyName: academyName, AcademyEmail: academyEmail, Password: password, Address: address, Country: country };


    return JSON.stringify({
        Academy: academy
    });
}

