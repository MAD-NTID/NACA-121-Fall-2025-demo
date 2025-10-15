public class Card
{
    public string Color { get; private set; }
    public string Label { get; private set; }
    public string Picture { get; private set; }
    public bool Flipped { get; private set; }

    public Card(string label, string color, string picture)
    {
        Label = label;
        Color = color;
        Picture = picture;
        Flipped = false;
    }

    public void Show()
    {
        Flipped = true;
    }
    public void Hide()
    {
        Flipped = false;
    }

    public override string ToString()
    {
        return $"Card info:\nLabel:{Label}\nColor:{Color}\nPicture:{Picture}\nFlipped:{Flipped}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Card)
            return false;

        Card card = (Card)obj;
        if (!card.Flipped || !Flipped)
            return false;

        return card.Label == Label && card.Picture == Picture &&
        card.Color == Color;
    }
}