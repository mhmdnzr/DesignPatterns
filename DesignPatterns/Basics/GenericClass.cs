using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Basics
{
    // pet feeder
    public static class GenericClass
    {
        public static void FeedPet<TP, TF>(TP pet, TF food) where TP : PetAnimal where TF : IPetFood
        {
            pet.Feed(food);
        }
    }
}
