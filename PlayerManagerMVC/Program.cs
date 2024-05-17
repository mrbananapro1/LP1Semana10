﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class Program
    {
        private static void Main() {

            List<Player> playerList = new List<Player>() {
                new Player("Best player ever", 100),
                new Player("An even better player", 500)
            };

            Controller controller = new Controller(playerList);

            IView view = new View(controller, playerList);

            controller.Start(view);
        }
    }
}