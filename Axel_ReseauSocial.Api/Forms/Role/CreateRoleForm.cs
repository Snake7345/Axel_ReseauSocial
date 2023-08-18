namespace Axel_ReseauSocial.Api.Forms.Role
{
    public class CreateRoleForm
    {
        public string Denomination { get; set; }

        public CreateRoleForm(string denomination)
        {
            Denomination = denomination;
        }
    }
}
