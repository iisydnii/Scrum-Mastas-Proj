/*-------------
Name: Austin Trivette
Date created: 10/13/21
Last Updated: 10/15/21
File name: Game.cs
Purpose: Control Game Logic
-------------
________________________________________________________________________________
Page Modified
    Piper Floyd, 10/24/21, lines 3o,58, Added player property so that other classes
                                        can access its values. Passed in player to 
                                        placement board. Deleted dice form property and method.
    Nataliya Chibizova 11/15/21 lines 129-134, added DisplayRetrospective.

*/
using System;
using ScrumAge;
using System.Windows.Forms;
using System.Collections.Generic;
 class Game
{

    public List<Player> PlayerList = SelectPlayersForm.players;
    public int stockprice = 1;

    // Forms
    private static LandingPageForm landingPageForm = new LandingPageForm();
    private static SelectPlayersForm SelectPlayersForm;
    private static Placement_Board placement_Board;
    private static RulesForm rulesForm;
    private static DiceForm diceForm;
    private static QuitGame quitGame;
    private static Winners_Losers winners_losers;
    private static SituationCardForm situationCardForm;
    private static Retrospective retrospective;
    

    public Game()
    {
        //do nothing 
    }

    // Starts the game by displaying the Title Screen
    public static void StartGame()
    {


        //landingPageForm = new LandingPageForm();
        landingPageForm.ShowDialog();

    }


    public static void DisplayRulesForm()
    {

        rulesForm = new RulesForm();
        rulesForm.Show();

    }


    public static void DisplaySetPlayersForm()
    {
        //Application.Run(new SelectPlayersForm());
        landingPageForm.Hide();

        SelectPlayersForm = new SelectPlayersForm();
        SelectPlayersForm.ShowDialog();

    }


    public static void DisplaySituationCardForm(Player currentPlayer, SituationCard sc)
    {
        situationCardForm = new SituationCardForm(currentPlayer, sc);
        situationCardForm.StartPosition = FormStartPosition.CenterParent;
        situationCardForm.ShowDialog();
        //placement_Board.Hide();
    }


    public void DisplayPlacementBoard()
    {
        placement_Board = new Placement_Board(PlayerList, stockprice);
        placement_Board.ShowDialog();

    }
    
    public static void DisplayQuitGame()
    {
        quitGame = new QuitGame();
        quitGame.StartPosition = FormStartPosition.CenterParent;
        quitGame.ShowDialog();
    }


    public static void DisplayDice()
    {
        diceForm = new DiceForm();
        diceForm.Show();
    }

    public static void DisplayWinners_Losers()
    {
        winners_losers = new Winners_Losers();
        winners_losers.StartPosition = FormStartPosition.CenterParent;
        winners_losers.ShowDialog();
    }


    ///TODO
    public static void DisplayRetrospective()
    {
        retrospective = new Retrospective();
        retrospective.StartPosition = FormStartPosition.CenterParent;
        retrospective.ShowDialog();
    }


    public static void CloseForm(Form form)
    {
        form.Close();
    }


    public static void QuitGame()
    {
        landingPageForm.Close();
    }


    // For Testing
    public static void Test()
    {
        StartGame();
        DisplaySetPlayersForm();

       

    }



}
