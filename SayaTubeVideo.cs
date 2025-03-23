using System;
public class SayaTubeVideo
{
	private int id;
	private String title;
	private int playCount;
	
	public SayaTubeVideo(String title)
	{
        Random acak = new Random();
		this.id = acak.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

	public void IncreasePlayCount(int PlayCount)
	{
		this.playCount += PlayCount;
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
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – DANIYAL ARSHAQ SUDRAJAT");
		video.IncreasePlayCount(50000);

    video.PrintVideoDetails();
    }
}

