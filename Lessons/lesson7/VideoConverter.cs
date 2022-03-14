using System.Threading.Tasks;

namespace lesson7
{
    public class VideoConverter
    {
        public delegate void VideoConverted(string message);
        public VideoConverted OnVideoConverted;
        public async Task Convert(string title)
        {
            await Task.Delay(3000);
            OnVideoConverted?.Invoke($"{title} video Converted Successfully ");
        }
    }
}