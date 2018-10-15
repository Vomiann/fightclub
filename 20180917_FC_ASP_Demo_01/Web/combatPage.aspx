<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/masterPage.Master" AutoEventWireup="true" CodeBehind="combatPage.aspx.cs" Inherits="_20180917_FC_ASP_Demo_01.Web.combatPage" %>

<asp:Content ID="ContentCombatPage" ContentPlaceHolderID="PageContent01" runat="server">
    <div class="container">
            <div class="row">
                <div class="col-sm-3 col-md-3 user_block">
                    <div class="user_block__name">
                        <span>User_1</span>
                    </div>

                    <div class="row user_block__hp">
                        <div class="col-sm-10 col-md-9">
                            <div class="user_block__hp__scale">
								<div class="user_block__hp__scale__change"></div>
							</div>
                        </div>
                        <div class="col-sm-2 col-md-3">
                            <span id="user_hp">?</span>/<span id="all_user_hp">?</span>
                        </div>
                    </div>

                    <div class="row equip">
                        <div class="col-md-3 charactersLeftBlock">
                            <img src="../img/helmet.png" alt="" />
                            <img src="../img/bracelet.png" alt="" />
                            <img src="../img/left-weapon.png" alt="" />
                            <img src="../img/breastplate.png" alt="" />
                            <img src="../img/belt.png" alt="" />
                        </div>
                        <div class="col-md-6 charactersCenterBlock">
							<img src="../img/user.png">
						</div>
                        <div class="col-md-3 charactersRightBlock">
                            <img src="../img/earrings.png" alt="" />
                            <img src="../img/necklace.png" alt="" />
                            <div class="rings">
                                <img src="../img/ring.png" width="18" height="18" alt="" />    
                                <img src="../img/ring.png" width="18" height="18" alt="" />
                                <img src="../img/ring.png" width="18" height="18" alt="" />
                            </div>
                            <img src="../img/gloves.png" alt="" />
                            <img src="../img/right-weapon.png" alt="" />
                            <img src="../img/leggings.png" alt="" />
                            <img src="../img/boots.png" alt="" />
                        </div>
                    </div>
                </div>


                <div class="col-sm-6 col-md-6 center_block">
                    <h3>Поединок</h3>
					<p id="your_turn"></p>
					<input type="button" id="start_game" value="Начать бой">
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
										<input type="radio" id="hit_stomach" name="group1" value="hit_stomach">
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
										<input type="radio" id="hit_groin" name="group1" value="hit_groin">
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
										<input type="radio" id="hit_legs" name="group1" value="hit_legs">
										<label for="hit_legs">удар в ноги</label>
									</td>
                                    <td></td>
									<td>
										<input type="radio" id="block_legs_and_head" name="group2" value="block_legs_and_head">
										<label for="block_legs_and_head">блок ног и головы</label>
									</td>
								</tr>

								<tr>
									<td colspan="3" class="btn_center"><input type="button" value="Вперед" id="fight"></td>
								</tr>
							</table>
                        </div>
                        <hr>
                        <div id="fight_log"></div>
                    </div>
                </div>
				
				
                <div class="col-sm-3 col-md-3 bot_block">
					<div class="bot_block__name">
                        <span>Bot_1</span>
                    </div>

                    <div class="row bot_block__hp">
                        <div class="col-sm-10 col-md-9">
                            <div class="bot_block__hp__scale">
								<div class="bot_block__hp__scale__change"></div>
							</div>
                        </div>
                        <div class="col-sm-2 col-md-3">
                            <span id="bot_hp">?</span>/<span id="all_bot_hp">?</span>
                        </div>
                    </div>

                    <div class="row equip">
                        <div class="col-md-3 charactersLeftBlock">
                            <img src="../img/helmet.png" alt="" />
                            <img src="../img/bracelet.png" alt="" />
                            <img src="../img/left-weapon.png" alt="" />
                            <img src="../img/breastplate.png" alt="" />
                            <img src="../img/belt.png" alt="" />
                        </div>
                        <div class="col-md-6 charactersCenterBlock">
							<img src="../img/bot.png">
						</div>
                        <div class="col-md-3 charactersRightBlock">
                            <img src="../img/earrings.png" alt="" />
                            <img src="../img/necklace.png" alt="" />
                            <div class="rings">
                                <img src="../img/ring.png" alt="" />    
                                <img src="../img/ring.png" alt="" />
                                <img src="../img/ring.png" alt="" />
                            </div>
                            <img src="../img/gloves.png" alt="" />
                            <img src="../img/right-weapon.png" alt="" />
                            <img src="../img/leggings.png" alt="" />
                            <img src="../img/boots.png" alt="" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
	<script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
	<script src="../js/index.js"></script>
</asp:Content>
