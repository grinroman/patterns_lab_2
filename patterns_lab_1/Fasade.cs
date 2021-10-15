using System;
using System.Collections.Generic;
using System.Text;

namespace patterns_lab_1
{
    class Cooking_Actions
    {
       public Cooking_Actions()
        {
            
        }

        public void Step_shopping() => Console.WriteLine("Идём в магазин");
        public void Step_Preparation() => Console.WriteLine("Возвращаемся домой и раскладываем продукты");
        public void Step_DropIng() => Console.WriteLine("Кладём творог на тарелку");
        public void Step_Cutbanana() => Console.WriteLine("Режем банан");
        public void Step_Mix() => Console.WriteLine("Смешиваем банан, творог, молоко и сгущенку");
    }

    class Cooking_Meal
    {
        Cooking_Actions zavtrak;
        public Cooking_Meal(Cooking_Actions zavtrak)
        {
            this.zavtrak = zavtrak;
        }

        public void Pohavat_breakfast()
        {
            zavtrak.Step_shopping();
            zavtrak.Step_Preparation();
            zavtrak.Step_DropIng();
            zavtrak.Step_Cutbanana();
            zavtrak.Step_Mix();
        }
    }
}
