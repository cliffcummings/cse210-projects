using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        LectureEvent   _lecture;
        ReceptionEvent _reception;
        OutdoorEvent   _outdoor;
        Address        _addr;

        PrintProgramHeader();
        _addr = new Address("123 Garden Way", "Provo", "UT", "84601");
        _lecture = new LectureEvent("Expert Gardening Techniques", "Teaches you how to make your garden bloom", "June 22, 2024", "2:00 pm", _addr.GetAddress(), "Green Thumbdude", 25);

        _lecture.DisplayStandardDetails("LECTURE");
        _lecture.DisplayFullDetails();
        _lecture.DisplayShortDescription();

        _addr = new Address("456 Bridal Drive", "Lehi", "UT", "84043");
        _reception = new ReceptionEvent("Jack & Jill Reception", "Wedding Reception of Jack & Jill", "June 29, 2024", "7:00 pm", _addr.GetAddress(), "rsvp@receptionhall.com");

        _reception.DisplayStandardDetails("RECEPTION");
        _reception.DisplayFullDetails();
        _reception.DisplayShortDescription();

        _addr = new Address("789 Canyon Ridge", "Highland", "UT", "84003");
        _outdoor = new OutdoorEvent("Mountain Climbing", "Join us as we climb Mt Timpanogos", "June 15, 2024", "8:00 am", _addr.GetAddress(), "Partly Cloudy");

        _outdoor.DisplayStandardDetails("OUTDOOR");
        _outdoor.DisplayFullDetails();
        _outdoor.DisplayShortDescription();

        void PrintProgramHeader()
        {
            Console.Clear();
            Console.WriteLine("\n\n------------------------------------------------");   
            Console.WriteLine("|-------- BEGINNING OF PROGRAM OUTPUT ---------|");   
            Console.WriteLine("------------------------------------------------");   
        }
    }
}