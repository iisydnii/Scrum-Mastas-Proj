/*-------------
Name: Sydni Ward
Date created: 10/11/21
File name: TestLocations.cs
Purpose: Test for Abstract class
________________________________________________________________________________
Page Modified
-------------*/
using System;

namespace ScrumAge
{
    class TestLocations : Locations
    {
        
        private int[,] TestPlayerList = new int[2, 4];

       public void SetPlayerList(int[,] playerList)
        {
            this.TestPlayerList = playerList;
        }

        public int[,] getPlayerList()
        {
            return TestPlayerList;
        }
    }
}
