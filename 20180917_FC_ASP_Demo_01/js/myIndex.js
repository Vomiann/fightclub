$(function () {

    $('#fight').click(function () {
        var hit = $('#fight_form input[name*="group1"]:checked').val();
        var block = $('#fight_form input[name*="group2"]:checked').val();
        console.log(hit);
        var hitAndBlock = {
            "hit": hit,
            "block": block
        };
        var str = JSON.stringify(hitAndBlock);
        $.ajax({
            type: "POST",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            url: "Default.aspx/JsonTest",    // JsonTest - тесовый метод, который возвращает hit и block в формате Json
            data: str,
            success: function (msg) {
                alert("Прибыли данные: " + msg.d);
            }
        });
    });


    function amountOfHealth(hp, characterName) {
        $('#' + characterName + '_hp').text(hp);
    }

    amountOfHealth(20, 'bot');


    function logFight(newText) {
        $('#fight_log').prepend('<p>' + newText + '</p>');
    }

    logFight('Hello');



    function clearLog() {
        $('#fight_log p').html(' ');
    }

    clearLog();


});



//$(function () {
//        $('#fight').click(function () {       
//            var hit = $('#fight_form input[name*="group1"]:checked').val();
//            var block = $('#fight_form input[name*="group2"]:checked').val();
//            var hitAndBlock = {
//                "hit": hit,
//                "block": block
//            };
//            var str = JSON.stringify(hitAndBlock);
            

//        $.ajax({           
//            type: "POST",
//            url: "Default.aspx/GetCurrentTime",
//            /*data: '{name: "' + str + '" }'*/
//            data: str,
//            contentType: "application/json; charset=utf-8", // charset=utf-8 не обязательно, но стоит установить
//            dataType: "json",
//            success: OnSuccess,
//            failure: function (response) {
//                alert(response.d);
//            }
//        });

//        function OnSuccess(response) {
//            alert("Прибыли данные:" + response.d);
//        }
//    });

//});


