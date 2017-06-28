$(document).ready(function() {
        $("#signUp").hide();
});

function goToSignUp()
{
    $("#login").hide();
    $("#signUp").show();
}

function goToLogin()
{
    $("#signUp").hide();
    $("#login").show();
}

function signUp()
{
    var academyName = $("#academyName").val();
    var academyEmail = $("#academyEmail").val();
    var password = $("#password").val();
    var street = $("#street").val();
    var zipCode = $("#zipCode").val();
    var country = $("#country").val();
    alert('academyName: ' + academyName);

}

function login()
{
    var login = $("#login").val();
    var passwordLogin = $("#passwordLogin").val();
    alert('login: ' + login);
}