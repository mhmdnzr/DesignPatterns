namespace DesignPatterns.Structual;

// The Target defines the domain-specific interface used by the client code.
public interface IJpgImage
{
    string GetRequest();
}

// The PngImages contains some useful behavior, but its interface is
// incompatible with the existing client code. The PngImages needs some
// adaptation before the client code can use it.
class PngImages
{
    public static string GetSpecificRequest()
    {
        return "Png Image Detected!";
    }
}

// The Adapter makes the PngImages's interface compatible with the Target's
// interface.
class Adapter : IJpgImage
{
    private readonly PngImages _pngImages;

    public Adapter(PngImages adaptee)
    {
        this._pngImages = adaptee;
    }

    public string GetRequest()
    {
        return $"This is '{PngImages.GetSpecificRequest()}'";
    }
}

static class ClientProgram
{
    public static void Main()
    {
        PngImages pngImage = new();
        IJpgImage jpgImage = new Adapter(pngImage);

        Console.WriteLine("PngImages interface is incompatible with the client.");
        Console.WriteLine("But with adapter client can call it's method.");

        Console.WriteLine(jpgImage.GetRequest());
    }
}
