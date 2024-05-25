// Exceeds Requirements
// Added Ninja Goal Warrior tracking and messages
// to the GoalManager.cs file.
// Four Ninja point levels defined.
// DisplayPlayerInfo enhanced to show Warrior status
// and required points for next Warrior level.
// Added NinjaDisplay private function to process
// Ninja messages and status.
// To test: Add a new SimpleGoal with Name Mega / 
// Description Points / Value 1050 - and record
// it multiple times to see Ninja status change.

using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");

        GoalManager gm = new GoalManager();

        gm.Start();
    }
}