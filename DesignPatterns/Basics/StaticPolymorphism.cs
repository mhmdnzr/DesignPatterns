using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Basics
{
    internal class StaticPolymorphism
    {
        public void Feed(PetDog dog)
        {
            PetFeeder.FeedPet(dog, new Kibble());
        }
        public void Feed(PetCat cat)
        {
            PetFeeder.FeedPet(dog, new Fish());
        }
    }
}
