using System.Collections.Generic;

namespace Common.ResourceProviders
{
    public class LocalImageProvider : IImageProvider
    {

        private Dictionary<string, string> _images = new();

        public LocalImageProvider()
        {
            _images["1"] = "hello world";
        }
        
        public string GetImagePathById(string id)
        {
            return _images[id];
        }
    }
}