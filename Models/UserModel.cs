namespace FacialRecognition.Models
{
    public class UserModel
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public List <Picture>? pictures { get; set; }

        public UserModel(string id)
        {
            Id = id;
        }
    }
}
