/*-------------
Name: Austin Trivette
Date created: 10/13/21
Last Updated: 10/13/21
File name: Game.cs
Purpose: Control Game Logic
-------------*/

using System;
using ScrumAge;
using System.Windows.Forms;
using System.Collections.Generic;

public static class Game
{
    // List of Players
    public static List<Player> PlayerList { get; set; }

    // Forms
    public static SelectPlayersForm selectPlayersForm;
    public static Placement_Board placement_Board;

    // Starts the game by displaying the Title Screen
    public static void StartGame()
    {
        Application.Run(new LandingPageForm());    
    }

    public static void DisplaySetPlayersForm()
    {
        //Application.Run(new SelectPlayersForm());

        selectPlayersForm = new SelectPlayersForm();
        selectPlayersForm.ShowDialog();

        //Populate PlayerList with all of the players
        PopulatePlayers();
    }

    public static void DisplayPlacementBoard()
    {
        placement_Board = new Placement_Board();

        foreach (var player in PlayerList)
        {
            //placement_Board = new Placement_Board(player.ID);
        }
        
    }

    //public static void DisplayActivationBoard()
    //{

    //}

    //public static void DisplayRetrospective()
    //{

    //}



    private static void PopulatePlayers()
    {
        PlayerList = new List<Player>();

        PlayerList = selectPlayersForm.GetPlayers();      
    }
}
