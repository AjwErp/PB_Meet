
//js for DGM Layout------------

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
//            li[i].style.display = "none


//        }
//    }
//}

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
/*------------DgmAccountsDepartmentReportsList-----start-js----*/



//$(document).ready(function () {
//    $('#DARReport').DataTable({
//        "sPaginationType": "full_numbers"
//    });
//});


//        $(document).ready(function () {
//            $('#MARReport').DataTable({
//                "sPaginationType": "full_numbers"
//            });
//        });


//        $(document).ready(function () {
//            $('#YARReport').DataTable({
//                "sPaginationType": "full_numbers"
//            });
//        });


//        $(document).ready(function () {
//            $('#AARReport').DataTable({
//                "sPaginationType": "full_numbers"
//            });
//        });
/*------------DgmAccountsDepartmentReportsList---ended---js----*/

/*//--DGM Daily Plan List---------start-------*/

/*//--DGM Daily Plan List---------Ended-------*/
//---------------AJW Notice Board---------------


//---------------AJW Notice Board---------------
//---------------AJW  DGM Office Report- start--------------


    //$(document).ready(function () {
    //        $('#DPReport').DataTable({
    //            "sPaginationType": "full_numbers"
    //        });
    //    });

    //    $(document).ready(function () {
    //        $('#MPReport').DataTable({
    //            "sPaginationType": "full_numbers"
    //        });
    //    });


    //    $(document).ready(function () {
    //        $('#YPReport').DataTable({
    //            "sPaginationType": "full_numbers"
    //        });
    //    });


    //    $(document).ready(function () {
    //        $('#APReport').DataTable({
    //            "sPaginationType": "full_numbers"
    //        });
    //    });
//---------------AJW  DGM Office Report---ended--------------

        //--------------back to top----start-----------
        var btn = $('#button');

        $(window).scroll(function () {
            if ($(window).scrollTop() > 300) {
                btn.addClass('show');
            } else {
                btn.removeClass('show');
            }
        });

        btn.on('click', function (e) {
            e.preventDefault();
            $('html, body').animate({ scrollTop: 0 }, '300');
        });
        //--------------back to top----ended-----------

//---JS for DGM LAW Book List----start----

$(document).ready(function () {
    $('#DGLBook').DataTable({
        "sPaginationType": "full_numbers"
    });
});