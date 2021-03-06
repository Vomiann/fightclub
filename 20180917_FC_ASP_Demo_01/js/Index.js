﻿$(function () {

    const allUserHp = 50;
    const allBotHp = 50;

    $('#start_game').click(function () {
        $.ajax({
            type: "POST",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            url: "combatPage.aspx/startGame",
            success: function () {
                startFight();
                unblockFightMenu();
                yourTurn();
            }
        }); 
    });


    $('#fight').click(function () {
        const hit = $('#fight_form input[name*="group1"]:checked').val();
        const block = $('#fight_form input[name*="group2"]:checked').val();
        const hitAndBlock = {
            "hit": hit,
            "block": block
        };
        const fightRoundData = JSON.stringify(hitAndBlock);

        blockButton();
        oppMove();

        $.ajax({
            type: "POST",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            url: "combatPage.aspx/round",
            data: fightRoundData,
            success: function (msg) {
                msg = JSON.parse(msg.d);
                unblockButton();
                amountOfHealth(msg.hpUser, 'user');
                amountOfHealth(msg.hpBot, 'bot');
                yourTurn();
                userLogFight(msg.userLog);
                botLogFight(msg.botLog);
                endGame(msg.endFight, msg.winner);
            },
            error: function () {
                yourTurn();
                unblockButton();
                alert('Вы не выбрали Атаку или Защиту');
            }
        });
    });



    function amountOfHealth(hp, characterName) {
        $('#' + characterName + '_hp').text(hp);
        const length = hp * 100 / allUserHp;
        $('.' + characterName + '_block__hp__scale__change').css('width', length + '%');

        const standardOfLiving = Math.round($('.' + characterName + '_block__hp__scale__change').width());
        const colorScale = $('.' + characterName + '_block__hp__scale__change');
        if (standardOfLiving <= 128 && standardOfLiving >= 79) {
            colorScale.css('background-color', 'yellow');
        } else if (standardOfLiving <= 78) {
            colorScale.css('background-color', 'red');
        }
    }

    function userLogFight(newText) {
        $('#fight_log').prepend('<p>' + newText + '</p>');
    }

    function botLogFight(newText) {
        $('#fight_log').prepend('<p>' + newText + '</p>');
    }

    function startFight() {
        $('.user_block__hp__scale__change, .bot_block__hp__scale__change').css({ 'width': '100%', 'background': 'green' });
        $('#user_hp, #all_user_hp').text(allUserHp);
        $('#bot_hp, #all_bot_hp').text(allBotHp);
        clearLog();
    }

    function unblockFightMenu() {
        $('#start_game').css('display', 'none');
        $('#your_turn, #fight_form').css('display', 'block');
        $('input:checked').prop('checked', false);
    }

    function blockFightMenu() {
        $('#start_game').css('display', 'block');
        $('#your_turn, #fight_form').css('display', 'none');
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

    function yourTurn() {
        $('#your_turn').text('Ваш ход');
    }

    function oppMove() {
        $('#your_turn').text('Ожидание хода противника');
    }

});


