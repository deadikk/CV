function fillBackground() {
    $(document.body).css("background-color", 'black');
}

function defineMonitorSize() {
    return JSON.stringify({ width: window.innerWidth, height: window.innerHeight });
}

function defineOneSymbolSize() {
    return JSON.stringify({ width: 10, height: 14 });
}

function getSymbolsCountForWindow() {
    var screenSize = JSON.parse(defineMonitorSize());
    var symbol = JSON.parse(defineOneSymbolSize());

    return JSON.stringify({
        horisontal: Math.round(screenSize.width / symbol.width) + 1,
        vertical: Math.round(screenSize.height / symbol.height) + 1,
    });
}

function initiateMatrix() {
    var screenSize = JSON.parse(defineMonitorSize());
    var symbolSize = JSON.parse(defineOneSymbolSize());
    var symbolsCount = JSON.parse(getSymbolsCountForWindow());

    var canvas = $('#bgCanvas').get(0);
    canvas.width = screenSize.width;
    canvas.height = screenSize.height;

    var width = screenSize.width;
    var height = screenSize.height;
    var verticalDistance = symbolSize.height;
    var horisontalDistance = symbolSize.width * 1.4;
    var columnHeight = height * 0.3;
    var columnHeightRandomizerPower = symbolsCount.vertical * 2 + symbolsCount.horisontal;
    var columnHeightRandomizer = columnHeightRandomizerPower * symbolSize.height;
    var symbolsVariability = 89;
    var fontSize = symbolSize.height;
    var drawSpeed = 60;
    var columns = symbolsCount.horisontal;

    var yPositions = Array(columns).join(0).split('');
    var ctx = $('#bgCanvas').get(0).getContext('2d');
    var opacity = 0.1;

    var drawMatrix = function () {
        ctx.fillStyle = 'rgba(0,0,0,' + opacity + ')';
        ctx.fillRect(0, 0, width, height);
        ctx.fillStyle = '#0F0';
        ctx.font = 'bold ' + fontSize + 'px Georgia';

        yPositions.map(function (y, index) {
            text = String.fromCharCode(12448 + Math.random() * symbolsVariability);
            x = (index * horisontalDistance);
            ctx.fillText(text, x, y);
            if (y > columnHeight + Math.random() * columnHeightRandomizer) {
                yPositions[index] = 0;
            }
            else {
                yPositions[index] = y + verticalDistance;
                
            }
        });
    }

    function RunMatrix() {
        if (typeof Game_Interval != "undefined") clearInterval(Game_Interval);
        Game_Interval = setInterval(drawMatrix, drawSpeed);
    }

    RunMatrix();

}