using ContosoPizza.Models;

namespace ContosoPizza.Services;

public static class PizzaService {

    static List<Pizza> Pizzas {get;}
    static int NextId = 6;
    static PizzaService() {
            Pizzas = new List<Pizza>{
                new Pizza{Id=1, Name = "Classic Italian", IsGlutenFree=false},
                new Pizza{Id=2, Name = "Veggie", IsGlutenFree=true},
                new Pizza{Id=3, Name = "Hawaiian", IsGlutenFree=false},
                new Pizza{Id=4, Name = "Pepperoni", IsGlutenFree=false},
                new Pizza{Id=5, Name = "Ham & Mushroom", IsGlutenFree=false}
            };
    }

    public static List<Pizza> GetAll()=> Pizzas;
    public static Pizza? Get(int id)=> Pizzas.FirstOrDefault(p => p.Id == id);
    public static void AddPizza(Pizza pizza){
        pizza.Id = NextId++;
        Pizzas.Add(pizza);
    }

    public static void Delete(int id){
        var pizza = Get(id);
        if (pizza is null)
            return;
        Pizzas.Remove(pizza);
    }
    public static void Update(Pizza pizza){
            var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
            if (index == -1)
            return;
            Pizzas[index] = pizza;
    }
    
}
