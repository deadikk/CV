function FirstOpen() {
    slowDisplay('#monitorDiv');
   
}

function slowDisplay(elementName) {
    var maxHeight = 600;
    var initialSize = 10;

    $(elementName).css({
        'display': 'block',
        'border-color': 'green',
        'border-width': '5px'
    });

    
    var myInterval = setInterval(function () { myTimer() }, 5);
    
    
    function myTimer() {
        $(elementName).css('height', initialSize);
        initialSize += 10;
        if (initialSize > maxHeight) {
            $(elementName).css('height', maxHeight);
            
            clearInterval(myInterval);
        }
    }
}

function slowHide(elementName) {
    
    var currentHieght = $(elementName).height();
    var myInterval = setInterval(function () { myTimer() }, 5);
    function myTimer() {
        $(elementName).css('height', currentHieght);
        currentHieght -= 10;
        if (currentHieght <= 0) {
            $(elementName).css('height', 0);
            clearInterval(myInterval);
            $(elementName).css({ 'border-color': 'white' });
            $(elementName).css({ 'border-width': '1px' });
            setTimeout(function() {
                $(elementName).css({ 'display': 'none' });
            }, 300);
        }
    }
}

function startInfoPrinting() {

    var textForPrinter = $('#printingSource').val();
    var textForLink = $('#nextPageLabel').val();
    var linkForNextPage = '';

    printer({
        selector: '#printingContent',
        text: textForPrinter ,
        fSuccess: function () {
            var str = $('#printingContent').html();
            $('#printingContent').html(str + "  <a class='blinking' href='#' onclick='showPage(\"" + linkForNextPage + "\");'>" + textForLink + "</a>  ");
            
            //iId = setInterval(function () {
            //    flag = !flag;
            //    $('#printingContent').html(str + (flag ? "  <a href='#' onclick='showPage(\"" + linkForNextPage + "\");'>" + textForLink + "</a>  " : ''));
            //}, 500);

            //setTimeout(function () {
            //    flag = true;
            //    clearInterval(iId);
            //}, 10 * 1000);
        }
    });

}