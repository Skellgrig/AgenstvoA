using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenstvoA
{
    public class AddClientViewModel
    {
        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PassportNumber { get; set; }
        public DateTime PassportIssueDate { get; set; }
        public string PassportIssuer { get; set; }
        public decimal Income { get; set; }
        public int? CreditScore { get; set; }

        public AddClientViewModel()
        {
        }

        public AddClientViewModel(Клиенты client)
        {
            ClientID = client.ClientID;
            FirstName = client.FirstName;
            LastName = client.LastName;
            MiddleName = client.MiddleName;
            DateOfBirth = client.DateOfBirth;
            Address = client.Address;
            PhoneNumber = client.PhoneNumber;
            Email = client.Email;
            PassportNumber = client.PassportNumber;
            PassportIssueDate = client.PassportIssueDate;
            PassportIssuer = client.PassportIssuer;
            Income = client.Income;
            CreditScore = client.CreditScore;
        }

        public void SaveClient()
        {
            using (var context = new AgenstvoEntities())
            {
                Клиенты client;
                if (ClientID == 0)
                {
                    client = new Клиенты();
                    context.Клиенты.Add(client);
                }
                else
                {
                    client = context.Клиенты.Find(ClientID);
                }

                client.FirstName = FirstName;
                client.LastName = LastName;
                client.MiddleName = MiddleName;
                client.DateOfBirth = DateOfBirth;
                client.Address = Address;
                client.PhoneNumber = PhoneNumber;
                client.Email = Email;
                client.PassportNumber = PassportNumber;
                client.PassportIssueDate = PassportIssueDate;
                client.PassportIssuer = PassportIssuer;
                client.Income = Income;
                client.CreditScore = CreditScore;

                context.SaveChanges();
            }
        }
    }
}