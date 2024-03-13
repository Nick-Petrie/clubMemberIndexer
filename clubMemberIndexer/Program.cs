using System.Drawing;


class ClubMembers
{
    private string[] Members = new string[Size];
    public string ClubType { get; set; }
    public string ClubLocation { get; set; }
    public string MeetingDate { get; set; }
    public const int Size = 15;  // global variable

    public ClubMembers()
    {
        ClubType = "";
        ClubLocation = "";
        MeetingDate = "";
    }
    //indexer get and set methods
    public string this[int i]
    {
        get
        {
            return Members[i];
        }
        set
        {
            Members[i] = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        ClubMembers member = new ClubMembers();
        member[0] = "Nick";
        member[1] = "Myles";
        member[2] = "McKenzie";

        member.ClubType = "Baby Swim Club Club";
        member.ClubLocation = "Community Pool";
        member.MeetingDate = "Sunday";
        Console.WriteLine($"Club Members: {member[0]}, {member[1]}, {member[2]}");
        Console.WriteLine($"It is located at the {member.ClubLocation}");
        Console.WriteLine($"We meet every {member.MeetingDate}");
    }
}