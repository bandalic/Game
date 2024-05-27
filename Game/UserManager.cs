using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Manager
    {
        public void Register(Player player)
        {
            Console.WriteLine(player.PlayerUsername + " kayıt oldu.");
        }
        public void Edit(Player player)
        {
            Console.WriteLine(player.PlayerUsername + " hesap bilgilerini düzenledi.");
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.PlayerUsername + " hesabını sildi.");
        }
    }
    
}

