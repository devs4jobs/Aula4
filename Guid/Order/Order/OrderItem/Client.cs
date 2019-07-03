using System;
namespace Order.OrderItem
{
    class Client
    {
        public string Name { get; set; }
        public String Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(){

        }
        public Client(String Nome,String email,DateTime birthdate)
        {
            Name = Nome;
            Email = email;
            BirthDate = birthdate;
        }

        public override string ToString()
        {
            return Name
                + ",("
                + BirthDate.ToString("dd/MM/yyyy")
                + ")-"
                + Email;
        }
    }
}
