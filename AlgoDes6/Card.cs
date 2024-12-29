namespace AlgoDes6;

public struct Card(int rank, Suits suit, string imagePath)
{
    public int Rank { get; set; } = rank;
    public Suits Suit { get; set; } = suit;
    public string ImagePath { get; set; } = imagePath;
}

