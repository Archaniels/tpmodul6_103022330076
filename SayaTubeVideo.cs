using System;
using System.Diagnostics;
public class SayaTubeVideo
{
	private int id;
	private String title;
	private int playCount;
	
	public SayaTubeVideo(String title)
	{
        Debug.Assert(title != null, "Title tidak boleh null");
        Debug.Assert(title.Length <= 100, "Title tidak boleh lebih dari 100 karakter");
		
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

	public void IncreasePlayCount(int PlayCount)
	{
        Debug.Assert(playCount > 0 && playCount <= 10000000, "PlayCount harus antara 1 hingga 10000000");

        try
        {
            checked
            {
                this.playCount += playCount;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("ERROR!");
        }
    }

	public void PrintVideoDetails()
	{
		Console.WriteLine("ID: " + this.id + ", " + this.title + " – " + this.playCount);
	}
}


class progRAM
{
    private static void Main(String[] args)
    {
        //test1 - title null
        try
        {
            SayaTubeVideo VIDEOinvalid = new SayaTubeVideo(null);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        //test2 - lebih dari 100 karakter
        try
        {
            SayaTubeVideo invalidVideo = new SayaTubeVideo(new string('A', 101));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – DANIYAL ARSHAQ SUDRAJAT");
        video.PrintVideoDetails();

        //test3 - playcount lebih dari batas maksimal
        try
        {
            video.IncreasePlayCount(15000000);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        //test4 - overflow
        for (int i = 0; i < 1000; i++)
        {
            video.IncreasePlayCount(10000000);
        }

        video.PrintVideoDetails();
    }
}

