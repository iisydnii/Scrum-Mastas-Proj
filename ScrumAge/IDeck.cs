/*-------------
Name: Garrett Dyer
Date created: 10/16/21
Last Updated: 10/16/21
File name: IDeck
Purpose: Creates the Deck interface. Defines the methods that the decks need to use.
-------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAge
{
    interface IDeck
    {
        void createDeck();
        void shuffleDeck();
        void drawCard();
    }
}
