using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenstvoA
{
    public class ClientsViewModel
    {
        public ObservableCollection<Клиенты> Clients { get; set; }

        public ClientsViewModel()
        {
            using (var context = new AgenstvoEntities())
            {
                Clients = new ObservableCollection<Клиенты>(context.Клиенты.ToList());
            }
        }

        public void DeleteClient(Клиенты client)
        {
            using (var context = new AgenstvoEntities())
            {
                context.Клиенты.Attach(client);
                context.Клиенты.Remove(client);
                context.SaveChanges();
            }

            Clients.Remove(client);
        }
    }
}
