$(function () {

    const allUserHp = 100;
    const allBotHp = 100;

    $('#start_game').click(function () {
        $.ajax({
            type: "POST",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            url: "Default.aspx/startGame",
            success: function () {
                $('#start_game').css('display', 'none');
                $('#your_turn, #fight_form').css('display', 'block');
                $('.user_block__hp__scale__change, .bot_block__hp__scale__change').css({ 'width': '100%', 'background': 'green' });
                $('#user_hp, #bot_hp').text('50');
                clearLog();
            }
        }); 
    });


    $('#fight').click(function () {
        var hit = $('#fight_form input[name*="group1"]:checked').val();
        var block = $('#fight_form input[name*="group2"]:checked').val();
        var hitAndBlock = {
            "hit": hit,
            "block": block
        };
        var str = JSON.stringify(hitAndBlock);
        $.ajax({
            type: "POST",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            url: "Default.aspx/JsonTest",	// JsonTest - тесовый метод, который возвращает hit и block в формате Json
            data: str,
            success: function (msg) {
                msg = JSON.parse(msg.d);
                amountOfHealth(msg.hpUser, 'user');
                amountOfHealth(msg.hpBot, 'bot');
                logFight(msg.log);
            }
        });
    });

    function amountOfHealth(hp, characterName) {
        $('#' + characterName + '_hp').text(hp);
        var length = hp * 100 / 50;
        $('.' + characterName + '_block__hp__scale__change').css('width', length + '%');

        var standardOfLiving = Math.round($('.' + characterName + '_block__hp__scale__change').width());
        var colorScale = $('.' + characterName + '_block__hp__scale__change');
        if (standardOfLiving <= 128 && standardOfLiving >= 79) {
            colorScale.css('background-color', 'yellow');
        } else if (standardOfLiving <= 78) {
            colorScale.css('background-color', 'red');
        }

    }

    function logFight(newText) {
        $('#fight_log').prepend('<p>' + newText + '</p>');
    }

    function clearLog() {
        $('#fight_log p').html('');
    }

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


