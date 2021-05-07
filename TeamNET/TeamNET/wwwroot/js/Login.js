function showPassword() {
    var x = document.getElementById("pwd");
    var y = document.getElementById("show");
    var z = document.getElementById("hide");

    if (x.type === 'password') {
        x.type = "text";
        y.style.display = "inline-block";
        z.style.display = "none";
    }
    else {
        x.type = "password";
        y.style.display = "none";
        z.style.display = "inline-block";
    }
}