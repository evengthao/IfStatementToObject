using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementToObject
{
    public class AnimalCreator
    {


        public static IActionable Create(string type)
        {
            Dictionary<string, IActionable> AnimalCollection = new Dictionary<string, IActionable>();
            AnimalCollection.Add("cat", new Cat());
            AnimalCollection.Add("dog", new Dog());
            AnimalCollection.Add("bird", new Bird());

            return AnimalCollection[type];
        }
    }
}
