using System;
using System.Collections.Generic;

namespace Day_5_Inheritance_Example
{
    // This will be a subclass of a PlayingCard
    // and will add what an AmericanPlaying needs that differs from a PlayingCard:

    //     Card values: 0 to 13 (Joker to King)
    //     Card suits/colors: Spades/Black, Clubs/Black, Hearts/Red, Diamonds/Red
    //     Default card/color: Joker/Black

    //               subclass      is-a superclass
    public class AmericanPlayingCard : PlayingCard  // Indicate PlayingCard is our base class
    {
        // We get access to all the data and methods in the base class PlayingCard
        // (So we don't need to define them again)

        /*************************************************************************************
         * Additional data required by the subclass
         ************************************************************************************/
        // Constants are used to facilitate coding and understanding
<<<<<<< HEAD:Unit-4-Intro-To-Object-Oriented-Programming/Day-5-Inheritaance-Example/Day-5-Inheritaance-Example/AmericanPlayingCard.cs
        // (C# coding convention: CONSTANT_NAMES - All uppercase; words seperated by underscores)
        // const indicates this data item is a constant - cannot be changed once assigned a value
=======
        // (C# coding convention: CONSTANT_NAMES - All uppercase; words separated by underscores)
        // const indicates this data item is a constant - cannot be changed once assigend a value
>>>>>>> c3585a4661c686c768ed96d9f29666c9a16c71f6:Unit-4-Intro-To-Object-Oriented-Programming/Day-5-Inheritance-Example-V1-Frank/Day-5-Inheritance-Example/AmericanPlayingCard.cs
        private const int    DEFAULT_CARD_VALUE = 0;
        private const string DEFAULT_COLOR      = "Black";
        private const string DEFAULT_SUIT       = "Joker";
        private const int    MAX_CARD_VALUE     = 13;   // King
        private const int    MIN_CARD_VALUE     = 0;    // Joker

<<<<<<< HEAD:Unit-4-Intro-To-Object-Oriented-Programming/Day-5-Inheritaance-Example/Day-5-Inheritaance-Example/AmericanPlayingCard.cs
        // Dictionary will associate suits and colors which are both strings
        private Dictionary<string, string> suitsColors = new Dictionary<string, string>();

        // So we can use names for the card values
=======
        // Dictionary will associate suits and colors
        private Dictionary<string, string> suitsColors = new Dictionary<string, string>();

        // So we can use names for the card values - indexes are the card values
>>>>>>> c3585a4661c686c768ed96d9f29666c9a16c71f6:Unit-4-Intro-To-Object-Oriented-Programming/Day-5-Inheritance-Example-V1-Frank/Day-5-Inheritance-Example/AmericanPlayingCard.cs
        // (defined for ease of use)
        private string[] cardValueName =//   0       1       2       3       4        5       6       7
                                        { "Joker", "Ace" , "Two", "Three", "Four" , "Five", "Six", "Seven",
                                          "Eight", "Nine", "Ten", "Jack" , "Queen", "King"
                                        //   8        9      10     11        12      13
                                        };

<<<<<<< HEAD:Unit-4-Intro-To-Object-Oriented-Programming/Day-5-Inheritaance-Example/Day-5-Inheritaance-Example/AmericanPlayingCard.cs
        // A Subclass constructor MUST call its Super Class constructor
        // to ensure the super class data is initialized
        //
        //
        // base() represets a base class constructor
        
        // Default Constructor for an AmericanPlayingCard - initialize a default playing card
        //     it must call the base() to initialize the base class
        // The super class has only a three-arg ctor so we have to call it to initialize the super class data
        
        //     this-class-ctor       : super-class-ctor
        public AmericanPlayingCard() : base(DEFAULT_CARD_VALUE, DEFAULT_SUIT, DEFAULT_COLOR) {}

        // 2-arg Constructor for an AmericanPlayingCard - allow a value and a suit (we decide the color)
=======
        // A Subclass constructor MUST call its Super Calsls constructor
        // to ensure teh super class data is initialied.
        // 
        // base() represents a base class ctor
        // 
        
        // Default Constructor for an AmericanPlayingCard - initialize default card
        //     it must call the base() to initialize the base class
        // The super class has only a 3-arg ctor so we have call it to initialize teh super class data

        //     this-class-ctor       : super-class ctor
        public AmericanPlayingCard() : base(DEFAULT_CARD_VALUE, DEFAULT_SUIT, DEFAULT_COLOR) {}

        // 2-arg Constructor for an AmericanPlayingCard - allow a value and suit (we decide color)
>>>>>>> c3585a4661c686c768ed96d9f29666c9a16c71f6:Unit-4-Intro-To-Object-Oriented-Programming/Day-5-Inheritance-Example-V1-Frank/Day-5-Inheritance-Example/AmericanPlayingCard.cs
        //       it must call the base() method to initialize the base class
        //        with any values it gets when instantiated
        //
        // Note: The super class (PlayingCard) only has a 3-arg ctor requiring a color
        //       We initialize the super class to default color since it's based on the suit
        //       We will change it once the processing in the constructor starts
        public AmericanPlayingCard(int theValue, string theSuit)
            : base(theValue, theSuit, DEFAULT_COLOR) // Pass all data to base class ctor
        {                                            // Actual card color will be set after suit is validated
            InitializeSuitColors();  // Call a method to setup our card suit/color dictionary

            // In the following code we are using the properties in the base class to set values
            // The base class owns it's data, so it's property know how to set its data
            //
            // Anything in the base class accessible to use can be accessed using base.

            if (!ValidateCardValue())                // If card value is invalid...
            {
                base.CardValue = DEFAULT_CARD_VALUE; //     set the card value to the default
            };
            if (!ValidateCardSuit())                 // if card suit is invalid...
            {
                base.CardSuit = DEFAULT_SUIT;        //     set the card suit to the default
            }

            base.CardColor = suitsColors[base.CardSuit]; // Set the card color based on the suit
        }

        /****************************************************************************************
         * Helper Methods for class - support class and manipulate data on behalf of the class
         ***************************************************************************************/

        // Initialize suitsColors Dictionary with valid suits and associated colors
        // It is private so access is limited to members of this class
        private void InitializeSuitColors()
        {
            suitsColors.Add("Spades"    , "Black");
            suitsColors.Add("Clubs"     , "Black");
            suitsColors.Add("Hearts"    , "Red");
            suitsColors.Add("Diamonds"  , "Red");
            suitsColors.Add(DEFAULT_SUIT, DEFAULT_COLOR);
        }

        // Validate card value - if invalid, reset to default value
        // It is private so access is limited to members of this class
        private bool ValidateCardValue()
        {
            if (base.CardValue < MIN_CARD_VALUE
             || base.CardValue > MAX_CARD_VALUE)
            {
                return false;
            }

            return true;
        }

        // Validate card suit - if invalid, reset to default suit
        // It is private so access is limited to members of this class
        private bool ValidateCardSuit()
        {
            if (!suitsColors.ContainsKey(base.CardSuit)) // If the current suit is not in the Dictionary
            {
                return false;                            //     it's not a valid suit
            }
            return true;
        }

        /****************************************************************************************
         * Overrides - Replace unwanted behavior of base class with behaviors for the subclass
         ***************************************************************************************/

        // No Overrides required as base class processing does what we want it to do

        /****************************************************************************************
         * User Methods for class - Allow user to use and manipulate the class
         ***************************************************************************************/

        public string GetCardValueName()
        {
            return cardValueName[base.CardValue];  // Use the card value as an an index to name array
        }

        // Display an object of the class
        public void ShowCard()
        {
            Console.WriteLine($"AmericanPlayingCard: Value: {GetCardValueName()} ({base.CardValue}), Suit: {base.CardSuit}, Color: {base.CardColor}");
        }
    }
}