/*-------------
Name: Austin Trivette
Date created: 10/13/21
Last Updated: 10/15/21
File name: Game.cs
Purpose: Control Game Logic
-------------*/

using System;
using ScrumAge;
using System.Windows.Forms;
using System.Collections.Generic;

public static class Game
{
    public static List<Player> PlayerList { get; set; }

    // Forms
    private static LandingPageForm landingPageForm;
    private static SelectPlayersForm selectPlayersForm;
    private static Placement_Board placement_Board;
    private static DiceForm diceForm;

    private static List<Form> AllForms;


    // Starts the game by displaying the Title Screen
    public static void StartGame()
    {
        landingPageForm = new LandingPageForm();
        landingPageForm.ShowDialog();
    }


    public static void DisplaySetPlayersForm()
    {
        //Application.Run(new SelectPlayersForm());

        selectPlayersForm = new SelectPlayersForm();
        selectPlayersForm.ShowDialog();

    }


    public static void DisplayPlacementBoard()
    {
        //Populate PlayerList with all of the players
        PopulatePlayers();

        foreach (var player in PlayerList)
        {
            placement_Board = new Placement_Board(player.Id);
            placement_Board.ShowDialog();
        }

        //placement_Board = new Placement_Board(1);
        //placement_Board.ShowDialog();
    }


    public static void DisplayDiceForm()
    {
        diceForm = new DiceForm();

        diceForm.ShowDialog();
    }
    
    ///TODO
    //public static void DisplayActivationBoard()
    //{

    //}

    ///TODO
    //public static void DisplayRetrospective()
    //{

    //}

    public static void CloseForm(Form form)
    {
        form.Close();
    }


    // For Testing
    public static void Test()
    {
        StartGame();
        DisplaySetPlayersForm();
        DisplayPlacementBoard();
        DisplayDiceForm();
    }


    private static void PopulatePlayers()
    {
        PlayerList = new List<Player>();

        PlayerList = selectPlayersForm.players;

    }
}
