//begin main
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

DisplayMenu();
string enjoymentLevel = GetEnjoymentLevel();
string stadiumRecommendation = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadiumRecommendation);
DisplayStadiumDetails(game, stadiumRecommendation);
//end main


static void DisplayMenu()
{
    System.Console.WriteLine("What is your prferred enjoyment level? \n1. Boring\n2. Average\n3. Fun\n4. Epic");
}

static string GetEnjoymentLevel()
{
    System.Console.WriteLine("Enter your level");
    string enjoymentLevel = Console.ReadLine();
    return enjoymentLevel;
}

static string GetStadiumRecommendation(string enjoymentLevel)
{
string stadiumRecommendation = "";
    if (enjoymentLevel.ToLower() == "boring")
    {
        stadiumRecommendation = "Neyland Stadium";
    }
    if (enjoymentLevel.ToLower() == "average")
    {
        stadiumRecommendation = "Jordan-Hare Stadium";
    }

    if (enjoymentLevel.ToLower() == "fun")
    {
        stadiumRecommendation = "Tiger Stadium";
    }
    if (enjoymentLevel.ToLower() == "epic")
    {
        stadiumRecommendation = "Saban Field at Bryant-Denny Stadium";
    }
    else
    {
       
    }

    return stadiumRecommendation;
}

static string GetGameRecommendation(string stadiumRecommendation)
{
    string game = "";
    if (stadiumRecommendation.ToLower() == "neyland stadium")
    {

        game = "Tenneessee vs Kent State";
    }
    if (stadiumRecommendation.ToLower() == "jordan-hare stadium")
    {
        game = "Auburn vs Kentucky";
    }
    if (stadiumRecommendation.ToLower() == "tiger stadium")
    {
        game = "Lsu vs Alabama";
    }
    if (stadiumRecommendation.ToLower() == "saban field at bryant-denny stadium")
    {
        game = "Alabama vs Auburn";
    }

    return game;
}

static void DisplayStadiumDetails(string game, string stadiumRecommendation)
{
System.Console.WriteLine($"Based on your preferneces, the game best for you is {game} at {stadiumRecommendation}");
}



