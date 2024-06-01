using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        LectureEvent   lecture;
        ReceptionEvent reception;
        OutdoorEvent   outdoor;
        Address        addr;

        PrintProgramHeader();
        addr = new Address("123 Garden Way", "Provo", "UT", "84601");
        lecture = new LectureEvent("Expert Gardening Techniques", "Teaches you how to make your garden bloom", "June 22, 2024", "2:00 pm", addr.GetAddress(), "Green Thumbdude", 25);

        lecture.DisplayStandardDetails("LECTURE");
        lecture.DisplayFullDetails();
        lecture.DisplayShortDescription();

        addr = new Address("456 Bridal Drive", "Lehi", "UT", "84043");
        reception = new ReceptionEvent("Jack & Jill Reception", "Wedding Reception of Jack & Jill", "June 29, 2024", "7:00 pm", addr.GetAddress(), "rsvp@receptionhall.com");

        reception.DisplayStandardDetails("RECEPTION");
        reception.DisplayFullDetails();
        reception.DisplayShortDescription();

        addr = new Address("789 Canyon Ridge", "Highland", "UT", "84003");
        outdoor = new OutdoorEvent("Mountain Climbing", "Join us as we climb Mt Timpanogos", "June 15, 2024", "8:00 am", addr.GetAddress(), "Partly Cloudy");

        outdoor.DisplayStandardDetails("OUTDOOR");
        outdoor.DisplayFullDetails();
        outdoor.DisplayShortDescription();

        void PrintProgramHeader()
        {
            Console.Clear();
            Console.WriteLine("\n\n------------------------------------------------");   
            Console.WriteLine("|-------- BEGINNING OF PROGRAM OUTPUT ---------|");   
            Console.WriteLine("------------------------------------------------");   
        }
    }
}