using PetCare.Common.Contracts;
using PetCare.Common.Notifications;
using PetCare.Common.ValueObjects;


namespace PetCare.Domain.ValueObjects
{
    public class Address: ValueObject
    {
        #region Properties
        public string Street { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        #endregion

        #region Constructors
        public Address(string street, string district, string city)
        {
            Street = street;
            District = district;
            City = city;

            ApplyContractsStreet();
            ApplyContractsDistrict();
            ApplyContractsCity();
        }
        #endregion

        #region Set Methods
        public void SetStreet(string street)
        {
            Street = street;
            ApplyContractsStreet();

        }
        public void SetDistrict(string district)
        {
            District = district;
            ApplyContractsDistrict();

        }
        public void SetCity(string city)
        {
            City = city;
            ApplyContractsCity();
        }
        #endregion

        private void ApplyContractsStreet()
        {
            AddNotifications(new Contract<Notification>()
               .Requires()
               .IsNotNull(Street, "Address.Street", "O endereço não pode ser nulo.")
               .IsNotEmpty(Street, "Address.Street", "O endereço não pode ser nulo.")
               .MinAndMaxLength(Street, 200, 3, "Address.Street", "O endereço não pode ter menos de 3 caractres e mais de 200."));
        }

        private void ApplyContractsDistrict()
        {
            AddNotifications(new Contract<Notification>()
               .Requires()
               .IsNotNull(District, "Address.District", "O bairro não pode ser nulo.")
               .IsNotEmpty(District, "Address.District", "O bairro não pode ser nulo.")
               .MinAndMaxLength(District, 60, 3, "Address.District", "O bairro precia ter entre 3 e 60 caracteres"));
        }
        private void ApplyContractsCity()
        {
            AddNotifications(new Contract<Notification>()
               .Requires()
               .IsNotNull(City, "Address.City", "A cidade não pode ser nula.")
               .IsNotEmpty(City, "Address.City", "A cidade não pode ser nula.")
               .MinAndMaxLength(City, 50, 3, "Address.City", "A cidade precia ter entre 3 e 50 caracteres"));
        }
    }
}
