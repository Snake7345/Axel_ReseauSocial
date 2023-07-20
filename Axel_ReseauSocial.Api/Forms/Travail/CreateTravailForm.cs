namespace Axel_ReseauSocial.Api.Forms.Travail
{
    public class CreateTravailForm
    {
        public string Denomination { get; set; }

        public CreateTravailForm(string denomination)
        {
            Denomination = denomination;
        }
    }
}
