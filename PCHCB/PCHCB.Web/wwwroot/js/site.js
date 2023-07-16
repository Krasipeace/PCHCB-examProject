// Back to top button functionality - start
const backToTopButton = document.getElementById("btn-back-to-top");

window.onscroll = function () { 
    scrollFunction() 
};

function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        backToTopButton.style.display = "block";
    } else {
        backToTopButton.style.display = "none";
    }
}

function toTopFunction() {
    window.scrollTo({
        top: 0,
        behavior: "smooth"
    });
}
// Back to top button functionality - end
