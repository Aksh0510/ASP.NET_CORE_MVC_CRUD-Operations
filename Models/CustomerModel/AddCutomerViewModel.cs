namespace ASPNET_CORE_MVC_CRUD.Models.CustomerModel
{
    public class AddCutomerViewModel
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
