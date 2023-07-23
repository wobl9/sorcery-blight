namespace Common.ResourceProviders
{
    public interface IImageProvider
    {
        string GetImagePathById(string id);
    }
}