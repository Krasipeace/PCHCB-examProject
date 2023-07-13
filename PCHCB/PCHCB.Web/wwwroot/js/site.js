// Back to top button functionality - start
window.onscroll = function () { 
    scrollFunction() 
    };

function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        document.getElementById("btn-back-to-top").style.display = "block";
    } else {
        document.getElementById("btn-back-to-top").style.display = "none";
    }
}

function toTopFunction() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
}
// Back to top button functionality - end
