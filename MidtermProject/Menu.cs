using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject
{
    class Menu
    {
        public void PrintStore()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Console.WriteLine($ "Item: {Items[i]} Price: {Price[i]}");
            }
        }
    }
}
