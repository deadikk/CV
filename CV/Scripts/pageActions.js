function FirstOpen() {
    slowDisplay('#monitorDiv');
    currentPage = ""
}

function slowDisplay(elementName) {
    var maxHeight = 570;
    var initialSize = 10;

    $(elementName).css({
        'display': 'block',
        'border-width': '5px'
    });


    var displayInterval = setInterval(function () { displayTimer() }, 5);


    function displayTimer() {
        $(elementName).css('height', initialSize);
        initialSize += 10;
        if (initialSize > maxHeight) {
            $(elementName).css('height', maxHeight);

            clearInterval(displayInterval);
        }
    }
}

function slowHide(elementName) {

    var currentHieght = $(elementName).height();
    var myInterval = setInterval(function () { hideTimer() }, 5);
    function hideTimer() {
        $(elementName).css('height', currentHieght);
        currentHieght -= 10;
        if (currentHieght <= 0) {
            $(elementName).css('height', 0);
            clearInterval(myInterval);
            //$(elementName).css({ 'border-width': '1px' });
            //setTimeout(function () {
            //    $(elementName).css({ 'display': 'none' });
            //}, 300);
        }
    }
}

function startInfoPrinting() {

    var textForPrinter = $('#printingSource').val();
    var textForLink = $('#nextPageLabel').val();
    var linkForNextPage = 'AboutPage';

    printer({
        selector: '#printingContent',
        text: textForPrinter,
        fSuccess: function () {
            var str = $('#printingContent').html();
            $('#printingContent').html(str + "  <a class='blinking' href='#' onclick='showPage(\"" + linkForNextPage + "\");'>" + textForLink + "</a>  ");
        }
    });

}

function showPage(pageName) {
    slowHide('#monitorDiv');
    
    setTimeout(function () {
        $(".displayWindow").css("display", "none");
        $(".displayWindow").children().css("display", "none");

        $("#" + pageName).css("display", "block");
        $("#" + pageName).children().css("display", "block");
        slowDisplay('#monitorDiv');
    }, 500);

}

function hideAll() {
    
}