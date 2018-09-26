$(function () {

    const allUserHp = 70;
    const allBotHp = 60;

    $('#start_game').click(function () {
        $.ajax({
            type: "POST",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            url: "Default.aspx/startGame",
            success: function () {
                startFight();
                blockFightMenu();
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

        blockButton();
        $.ajax({
            type: "POST",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            url: "Default.aspx/JsonTest",	// JsonTest - тесовый метод, который возвращает hit и block в формате Json
            data: str,
            success: function (msg) {
                msg = JSON.parse(msg.d);
                unblockButton();
                amountOfHealth(msg.hpUser, 'user');
                amountOfHealth(msg.hpBot, 'bot');
                logFight(msg.log);
                endGame(msg.endFight, msg.winner);
            },
            error: function () {
                alert('Ошибка');
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

    function startFight() {
        $('.user_block__hp__scale__change, .bot_block__hp__scale__change').css({ 'width': '100%', 'background': 'green' });
        $('#user_hp, #all_user_hp').text(allUserHp);
        $('#bot_hp, #all_bot_hp').text(allBotHp);
        clearLog();
    }

    function blockFightMenu() {
        $('#start_game').css('display', 'none');
        $('#your_turn, #fight_form').css('display', 'block');
    }

    function clearLog() {
        $('#fight_log p').html('');
    }

    function endGame(endFight, winner) {
        if (endFight === true) {
            blockFightMenu();
            alert(winner);
        }
    }

    function blockButton() {
        $('#fight').attr('disabled', true);
    }

    function unblockButton() {
        $('#fight').attr('disabled', false);
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


