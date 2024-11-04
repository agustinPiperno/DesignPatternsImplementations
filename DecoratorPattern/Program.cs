using DecoratorPattern.Entities.Burgers;
using DecoratorPattern.Entities.Decorators;

Burger burger = new TLOBurger();
Console.WriteLine(burger.Description + " - " + burger.Calories() + " cals");
Burger burgerWithExtraMayo = new Mayo(burger);
Console.WriteLine(burgerWithExtraMayo.Description + " - " + burgerWithExtraMayo.Calories() + " cals");
Burger burgerWithExtraMayoAndExtraCheese = new Cheese(burgerWithExtraMayo);
Console.WriteLine(burgerWithExtraMayoAndExtraCheese.Description + " - " + burgerWithExtraMayoAndExtraCheese.Calories() + " cals");
