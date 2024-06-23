namespace FacialRecognition.Models
{
    public class Picture
    {

        public  string? OriginalImage { get; set; }
        public string? ScannedImage { get; set; }

        public Picture(string originalImage)
        {
            OriginalImage = originalImage;
        }

    }
}
