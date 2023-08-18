namespace Axel_ReseauSocial.Api.Forms.Role
{
    public class UpdateRoleForm
    {
        public string Denomination { get; set; }

        public UpdateRoleForm(string denomination)
        {
            Denomination = denomination;
        }
    }
}
