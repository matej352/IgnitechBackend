namespace IgnitechWebApi.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid? StudentCode { get; set; }
        public Guid? TeacherCode { get; set; }
    }
}
