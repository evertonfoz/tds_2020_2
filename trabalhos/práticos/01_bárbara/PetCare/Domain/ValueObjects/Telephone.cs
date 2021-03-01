using PetCare.Common.Contracts;
using PetCare.Common.Notifications;
using PetCare.Common.ValueObjects;


namespace PetCare.Domain.ValueObjects
{
    public class Telephone : ValueObject
    {
        #region Properties
        public string Residential { get; private set; }
        public string Cell { get; private set; }
        #endregion

        #region Constructors
        public Telephone(string residential, string cell)
        {
            Residential = residential;
            Cell = cell;

            ApplyContractsResidential();
            ApplyContractsCell();
        }
        #endregion

        #region Set Methods
        public void SetResidential(string residential)
        {
            Residential = residential;
            ApplyContractsResidential();

        }
        public void SetCell(string cell)
        {
            Cell = cell;
            ApplyContractsCell();

        }
        #endregion

        private void ApplyContractsResidential()
        {
            AddNotifications(new Contract<Notification>()
               .MinAndMaxLengthNumber(Residential, 10, 13, "Telephone.Residential", "O numero residencial precisa ter de 10 a 13 caracteres (dd+numero ou (dd)numero com -)"));
        }

        private void ApplyContractsCell()
        {
            AddNotifications(new Contract<Notification>()
               .Requires()
               .IsNotNull(Cell, "Telephone.Cell", "O celular não pode ser nulo.")
                .IsNotEmpty(Cell, "Telephone.Cell", "O celular não pode ser nulo.")
              .MinAndMaxLengthNumber(Cell, 10, 13, "Telephone.Cell", "O numero de celular precisa ter de 11 a 14 caracteres (dd + 9+ numero ou (dd) 9 + numero com -)"));
        }
    }
}
