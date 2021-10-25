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

*/
using System;
using ScrumAge;
using System.Windows.Forms;
using System.Collections.Generic;

public class Game
{

    public static List<Player> PlayerList { get; set; }
    

    // Forms
    private static LandingPageForm landingPageForm;
    private static SelectPlayersForm selectPlayersForm;
    private static Placement_Board placement_Board;
    

    private static List<Form> AllForms;
    public Player player;

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
            placement_Board = new Placement_Board(player);
            placement_Board.ShowDialog();
        }

        //placement_Board = new Placement_Board(1);
        //placement_Board.ShowDialog();
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

       

    }


    private static void PopulatePlayers()
    {
        PlayerList = new List<Player>();

        PlayerList = selectPlayersForm.players;

    }




}
