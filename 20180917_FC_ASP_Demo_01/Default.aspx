﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_20180917_FC_ASP_Demo_01.Default" %>


<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" type="text/css" href="css/style.css">
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-md-3 user_block">
                <div class="user_block__name">
                    <span>User_1</span>
                </div>

                <div class="row user_block__hp">
                    <div class="col-md-9">
                        <div class="user_block__hp_scale"></div>
                    </div>
                    <div class="col-md-3">
                        <span><span id="user_hp">45</span>/50</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-3"></div>
                    <div class="col-md-6">
                        <img src="img/character.png">
                    </div>
                    <div class="col-md-3"></div>
                </div>
            </div>


            <div class="col-md-6 center_block">
                <h3>Поединок</h3>
                <p>Ваш ход</p>
                <div class="row">
                    <div id="fight_form">
                        <table class="center_block__fight_info">
                            <tr>
                                <td>
                                    <p>Атака</p>
                                </td>
                                <td></td>
                                <td>
                                    <p>Защита</p>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <input type="radio" id="hit_head" name="group1" value="hit_head">
                                    <label for="hit_head">удар в голову</label>
                                </td>
                                <td></td>
                                <td>
                                    <input type="radio" id="block_head_and_chest" name="group2" value="block_head_and_chest">
                                    <label for="block_head_and_chest">блок головы и груди</label>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <input type="radio" id="hit_chest" name="group1" value="hit_chest">
                                    <label for="hit_chest">удар в грудь</label>
                                </td>
                                <td></td>
                                <td>
                                    <input type="radio" id="block_chest_and_stomach" name="group2" value="block_chest_and_stomach">
                                    <label for="block_chest_and_stomach">блок груди и живота</label>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <input type="radio" id="stomach" name="group1" value="stomach">
                                    <label for="hit_stomach">удар в живот</label>
                                </td>
                                <td></td>
                                <td>
                                    <input type="radio" id="block_stomach_and_groin" name="group2" value="block_stomach_and_groin">
                                    <label for="block_stomach_and_groin">блок живота и пояса</label>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <input type="radio" id="groin" name="group1" value="groin">
                                    <label for="hit_groin">удар в пояс(пах)</label>
                                </td>
                                <td></td>
                                <td>
                                    <input type="radio" id="block_groin_and_legs" name="group2" value="block_groin_and_legs">
                                    <label for="block_groin_and_legs">блок пояса и ног</label>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <input type="radio" id="legs" name="group1" value="legs">
                                    <label for="hit_legs">удар в ноги</label>
                                </td>
                                <td></td>
                                <td>
                                    <input type="radio" id="block_legs_and_head" name="group2" value="block_legs_and_head">
                                    <label for="block_legs_and_head">блок ног и головы</label>
                                </td>
                            </tr>

                            <tr>
                                <td colspan="3" align="center">
                                    <input type="button" value="Вперед" id="fight"></td>
                            </tr>
                        </table>
                    </div>
                    <hr>
                    <div id="fight_log"></div>
                </div>
            </div>


            <div class="col-md-3 bot_block">
                <div class="bot_block__name">
                    <span>Bot_1</span>
                </div>

                <div class="row bot_block__hp">
                    <div class="col-md-9">
                        <div class="bot_block__hp_scale"></div>
                    </div>
                    <div class="col-md-3">
                        <span><span id="bot_hp">45</span>/50</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-3"></div>
                    <div class="col-md-6">
                        <img src="img/character.png">
                    </div>
                    <div class="col-md-3"></div>
                </div>
            </div>
        </div>
    </div>
    <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
    <script src="js/myIndex.js"></script>
</body>
</html>




<!-- Old version  -->

<%--<!DOCTYPE html>

<html>
    <head>
        <title></title>        
    </head>
    <body style = "font-family:Arial; font-size:10pt">
        <form id="form1">
            <div>               
               <input id="btnGetTime" type="button" value="Show Current Time" onclick ="ShowCurrentTime()" />
            </div>
        </form>       
        <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
        <script src="js/index.js"></script>
    </body>
</html>--%>







