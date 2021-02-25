using PetCare.Domain.Models;
using PetCare.Domain.Repositories;
using PetCare.Domain.ValueObjects;
using PetCare.Persistence.Repositories;
using System;

namespace PetCare.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var owner = new OwnerModel(new Name("Asbranzio", "Castiofie"), "asbranzio1@gmail.com");
            OwnerModel owner;

            using (IOwnerRepository repository = new OwnerRepository())
            {
                owner = repository.GetByEMail("asbranzio1@gmail.com");
                repository.Delete(owner);
                //owner.ChangeEmail("asbranzio2@gmail.com");
                //repository.Update(owner);
                //owner = repository.GetByID(Guid.Parse("1193221c-5e75-4b65-8a56-e4f8cafaf202"));
                //repository.Create(owner);
            }

            Console.WriteLine("Concluído com sucesso");
            Console.ReadKey();
        }
    }
}
