//js for Admin Layout---------------

//function myFunction() {
//    var input, filter, ul, li, a, i;
//    input = document.getElementById("mySearch");
//    filter = input.value.toUpperCase();
//    ul = document.getElementById("menu");
//    li = ul.getElementsByTagName("li");

//    for (i = 0; i < li.length; i++) {
//        a = li[i].getElementsByTagName("a")[0];
//        if (a.innerHTML.toUpperCase().indexOf(filter) > -1) {
//            li[i].style.display = "";
//        } else {
//            li[i].style.display = "none";

//        }
//    }
//}

//----------------------------------------
//$(document).ready(function () {
//    $('#RUTable').DataTable();
//});


//---------JS for Back To Top Button On Each Page------------------Start-------
//var btn = $('#button');

//$(window).scroll(function () {
//    if ($(window).scrollTop() > 300) {
//        btn.addClass('show');
//    } else {
//        btn.removeClass('show');
//    }
//});

//btn.on('click', function (e) {
//    e.preventDefault();
//    $('html, body').animate({ scrollTop: 0 }, '300');
//});

//---JS for Admin LAW Book List----start----
//$(document).ready(function () {
//    $('#DGLBook').DataTable({
//        "sPaginationType": "full_numbers"
//    });
//});