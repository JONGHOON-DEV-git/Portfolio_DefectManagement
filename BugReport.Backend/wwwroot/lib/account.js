document.addEventListener('DOMContentLoaded', function () {
    var token = localStorage.getItem('jwtToken');
    var navbar = document.getElementById('nav-account');
    var links = '';
    if (token) {
        // JWT 토큰이 있을 경우
        $.ajax({
            url: '/api/profile',
            headers: {
                'Authorization': 'Bearer ' + token
            },
            success: function (data) {
                SetAuthrizeState(true);
            },
            error: function () {
                SetAuthrizeState(false);
            }
        });
    } else {
        // JWT 토큰이 없을 경우
        SetAuthrizeState(false);
    }
});


function SetAuthrizeState(isLogin) {
    if (isLogin) {
        document.getElementById("btnLogin").style.display = "none";
        document.getElementById("btnSignUp").style.display = "none";
        document.getElementById("btnLogout").style.display = "block";
    }
    else {
        document.getElementById("btnLogin").style.display = "block";
        document.getElementById("btnSignUp").style.display = "block";
        document.getElementById("btnLogout").style.display = "none";
    }
}

function logout() {

}
