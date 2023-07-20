namespace Axel_ReseauSocial.Api.Forms.Role
{
    public class CreateRole
    {


        public string Denomination { get; set; }

        public CreateRole(string denomination)
        {
            Denomination = denomination;
        }
    }
}
