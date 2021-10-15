//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace patterns_lab_1
//{
//    class Pizza
//    {
//        public virtual string MakePizza => "Pizza => ";
//    }

//    class PepperoniPizza: Pizza
//    {
//        Pizza pizza;
//        public PepperoniPizza(Pizza dough)
//        {
//            this.pizza = dough;
//        }
//        public override string MakePizza => base.MakePizza + "pepperoni=>";
//    }

//    class Bacon: Pizza
//    {
//        Pizza pizza;
//        public Bacon (Pizza pizza)
//        {
//            this.pizza = pizza;
//        }
//        public override string MakeDoshik => pizza.MakeDoshik + "add bacon =>";
//    }
//}
