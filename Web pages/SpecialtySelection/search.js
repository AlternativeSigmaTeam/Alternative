function myFunction() {
    var input, filter, ul, li, a, i;
    input = document.getElementById('myInput');
    filter = input.value.toUpperCase();
    ul = document.getElementById("myUL");
    li = ul.getElementsByTagName('li');

    for (i = 0; i < li.length; i++) {
        a = li[i].getElementsByTagName("a")[0];
        if (a.innerHTML.toUpperCase().indexOf(filter) > -1) {
            li[i].style.display = "";
        } else {
            li[i].style.display = "none";
        }
    }
}

$(document).ready(function () {
    $('a#link').click(function (e) {
        $(this).toggleClass('active');
        $('#content').toggle();

        e.stopPropagation();
    });

    $('body').click(function () {
        var link = $('a#link1');
        if (link.hasClass('active')) {
            link.click();
        }
    });
});