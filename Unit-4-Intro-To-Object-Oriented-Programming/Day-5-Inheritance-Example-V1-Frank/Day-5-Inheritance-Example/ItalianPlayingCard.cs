<<<<<<< HEAD:Unit-4-Intro-To-Object-Oriented-Programming/Day-5-Inheritaance-Example/Day-5-Inheritaance-Example/ItalianPlayingCard.cs
using Day_3_Inheritance;

namespace Day_5_Inheritance_Example;

// This is a subclass of a PlayingCard

public class ItalianPlayingCard : PlayingCard
{
 
    // Define a default ctor that calls the base class ctor
    public ItalianPlayingCard() : base(0, "Joker", "Black") {}

    // Define a 2 arg ctor for value and suit

    public ItalianPlayingCard(int theValue, string theSuit, string theColor)
        : base(theValue, theSuit, theColor){}

=======
﻿namespace Day_5_Inheritance_Example;

// This is subclass of a PlayingCard

public class ItalianPlayingCard : PlayingCard
{
    // Define a default ctor that calls the base class ctor
    public ItalianPlayingCard() : base(0, "Joker", "Black") {}

    // Define a 2-arg ctor for value and suit
    public ItalianPlayingCard(int theValue, string theSuit, string theColor)
      : base(theValue, theSuit, theColor){}
>>>>>>> c3585a4661c686c768ed96d9f29666c9a16c71f6:Unit-4-Intro-To-Object-Oriented-Programming/Day-5-Inheritance-Example-V1-Frank/Day-5-Inheritance-Example/ItalianPlayingCard.cs
}