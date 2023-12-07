using TuberTreats.Models;

List<Customer> customers = new List<Customer>()
{
    new Customer { Id = 1, Name = "Ava Martinez", Address = "962 Birch Boulevard, New York, CA 60629" },
    new Customer { Id = 2, Name = "Sophia Davis", Address = "798 Spruce Court, San Diego, IL 31275" },
    new Customer { Id = 3, Name = "Olivia Brown", Address = "608 Willow Way, San Diego, CA 28038" },
    new Customer { Id = 4, Name = "Mason Garcia", Address = "744 Walnut Place, Los Angeles, CA 91363" },
    new Customer { Id = 5, Name = "Ava Brown", Address = "229 Willow Way, Philadelphia, TX 64279" },
    new Customer { Id = 6, Name = "Sophia Williams", Address = "333 Walnut Place, San Antonio, CA 36619" },
    new Customer { Id = 7, Name = "Sophia Davis", Address = "148 Pine Drive, Philadelphia, TX 73717" },
    new Customer { Id = 8, Name = "Logan Davis", Address = "643 Maple Street, Houston, PA 82589" }
};
List<Topping> toppings = new List<Topping>()
{
    new Topping { Id = 1, Name = "Pepperoni" },
    new Topping { Id = 2, Name = "Mushrooms" },
    new Topping { Id = 3, Name = "Onions" },
    new Topping { Id = 4, Name = "Sausage" },
    new Topping { Id = 5, Name = "Bacon" },
    new Topping { Id = 6, Name = "Extra cheese" },
    new Topping { Id = 7, Name = "Black olives" },
    new Topping { Id = 8, Name = "Green peppers" },
    new Topping { Id = 9, Name = "Pineapple" },
    new Topping { Id = 10, Name = "Spinach" }
};
List<TuberDriver> drivers = new List<TuberDriver>()
{
    new TuberDriver { Id = 1, Name = "John Doe" },
    new TuberDriver { Id = 2, Name = "Jane Smith" },
    new TuberDriver { Id = 3, Name = "Alex Johnson" }
};
List<TuberOrder> orders = new List<TuberOrder>()
{
    new TuberOrder { Id = 1, OrderPlacedOnDate = new DateTime(2023, 3, 8), CustomerId = 2, TuberDriverId = 1, DeliveredOnDate = new DateTime(2023, 11, 10) },
    new TuberOrder { Id = 2, OrderPlacedOnDate = new DateTime(2023, 3, 12), CustomerId = 1, TuberDriverId = 2, DeliveredOnDate = new DateTime(2023, 11, 10) },
    new TuberOrder { Id = 3, OrderPlacedOnDate = new DateTime(2023, 9, 5), CustomerId = 7, TuberDriverId = 3, DeliveredOnDate = new DateTime(2023, 11, 10) },
    new TuberOrder { Id = 4, OrderPlacedOnDate = new DateTime(2023, 4, 15), CustomerId = 4, TuberDriverId = 2, DeliveredOnDate = new DateTime(2023, 11, 10) },
    new TuberOrder { Id = 5, OrderPlacedOnDate = new DateTime(2023, 2, 20), CustomerId = 5, TuberDriverId = 1, DeliveredOnDate = new DateTime(2023, 11, 10) },
    new TuberOrder { Id = 6, OrderPlacedOnDate = new DateTime(2023, 1, 10), CustomerId = 3, TuberDriverId = 1, DeliveredOnDate = new DateTime(2023, 11, 11) },
    new TuberOrder { Id = 7, OrderPlacedOnDate = new DateTime(2023, 5, 22), CustomerId = 6, TuberDriverId = 3, DeliveredOnDate = new DateTime(2023, 11, 12) },
    new TuberOrder { Id = 8, OrderPlacedOnDate = new DateTime(2023, 6, 30), CustomerId = 8, TuberDriverId = 3, DeliveredOnDate = new DateTime(2023, 11, 12) },
    new TuberOrder { Id = 9, OrderPlacedOnDate = new DateTime(2023, 7, 14), CustomerId = 4, TuberDriverId = 2, DeliveredOnDate = new DateTime(2023, 11, 13) },
    new TuberOrder { Id = 10, OrderPlacedOnDate = new DateTime(2023, 8, 5), CustomerId = 2, TuberDriverId = 1, DeliveredOnDate = new DateTime(2023, 11, 13) },
    new TuberOrder { Id = 11, OrderPlacedOnDate = new DateTime(2023, 10, 11), CustomerId = 1, TuberDriverId = 1, DeliveredOnDate = new DateTime(2023, 11, 13) },
    new TuberOrder { Id = 12, OrderPlacedOnDate = new DateTime(2023, 11, 20), CustomerId = 5, TuberDriverId = 3, DeliveredOnDate = new DateTime(2023, 11, 14) },
    new TuberOrder { Id = 13, OrderPlacedOnDate = new DateTime(2023, 12, 2), CustomerId = 3, TuberDriverId = 2, DeliveredOnDate = new DateTime(2023, 11, 14) },
    new TuberOrder { Id = 14, OrderPlacedOnDate = new DateTime(2023, 1, 8), CustomerId = 7, TuberDriverId = 2, DeliveredOnDate = new DateTime(2023, 11, 14) },
    new TuberOrder { Id = 15, OrderPlacedOnDate = new DateTime(2023, 2, 17), CustomerId = 8, TuberDriverId = 1, DeliveredOnDate = new DateTime(2023, 11, 14) },
    new TuberOrder { Id = 16, OrderPlacedOnDate = new DateTime(2023, 3, 25), CustomerId = 6, TuberDriverId = 3, DeliveredOnDate = new DateTime(2023, 11, 15) },
    new TuberOrder { Id = 17, OrderPlacedOnDate = new DateTime(2023, 4, 30), CustomerId = 4, TuberDriverId = 3 },
    new TuberOrder { Id = 18, OrderPlacedOnDate = new DateTime(2023, 6, 15), CustomerId = 2, TuberDriverId = 2 },
    new TuberOrder { Id = 19, OrderPlacedOnDate = new DateTime(2023, 7, 21), CustomerId = 1, TuberDriverId = 1 },
    new TuberOrder { Id = 20, OrderPlacedOnDate = new DateTime(2023, 8, 8), CustomerId = 5 }
};
List<TuberTopping> orderToppings = new List<TuberTopping>
{
    new TuberTopping { Id = 1, TuberOrderId = 1, ToppingId = 1 },
    new TuberTopping { Id = 2, TuberOrderId = 1, ToppingId = 2 },
    new TuberTopping { Id = 3, TuberOrderId = 2, ToppingId = 4 },
    new TuberTopping { Id = 4, TuberOrderId = 2, ToppingId = 2 },
    new TuberTopping { Id = 5, TuberOrderId = 2, ToppingId = 3 },
    new TuberTopping { Id = 6, TuberOrderId = 3, ToppingId = 6 },
    new TuberTopping { Id = 7, TuberOrderId = 3, ToppingId = 4 },
    new TuberTopping { Id = 8, TuberOrderId = 3, ToppingId = 9 },
    new TuberTopping { Id = 9, TuberOrderId = 4, ToppingId = 7 },
    new TuberTopping { Id = 10, TuberOrderId = 4, ToppingId = 10 },
    new TuberTopping { Id = 11, TuberOrderId = 5, ToppingId = 7 },
    new TuberTopping { Id = 12, TuberOrderId = 5, ToppingId = 10 },
    new TuberTopping { Id = 13, TuberOrderId = 5, ToppingId = 8 },
    new TuberTopping { Id = 14, TuberOrderId = 6, ToppingId = 5 },
    new TuberTopping { Id = 15, TuberOrderId = 6, ToppingId = 6 },
    new TuberTopping { Id = 16, TuberOrderId = 7, ToppingId = 3 },
    new TuberTopping { Id = 17, TuberOrderId = 8, ToppingId = 4 },
    new TuberTopping { Id = 18, TuberOrderId = 8, ToppingId = 2 },
    new TuberTopping { Id = 19, TuberOrderId = 8, ToppingId = 9 },
    new TuberTopping { Id = 20, TuberOrderId = 9, ToppingId = 3 },
    new TuberTopping { Id = 21, TuberOrderId = 9, ToppingId = 4 },
    new TuberTopping { Id = 22, TuberOrderId = 10, ToppingId = 8 },
    new TuberTopping { Id = 23, TuberOrderId = 10, ToppingId = 7 },
    new TuberTopping { Id = 24, TuberOrderId = 11, ToppingId = 9 },
    new TuberTopping { Id = 25, TuberOrderId = 11, ToppingId = 6 },
    new TuberTopping { Id = 26, TuberOrderId = 12, ToppingId = 4 },
    new TuberTopping { Id = 27, TuberOrderId = 12, ToppingId = 2 },
    new TuberTopping { Id = 28, TuberOrderId = 13, ToppingId = 7 },
    new TuberTopping { Id = 29, TuberOrderId = 13, ToppingId = 4 },
    new TuberTopping { Id = 30, TuberOrderId = 14, ToppingId = 1 },
    new TuberTopping { Id = 31, TuberOrderId = 14, ToppingId = 9 },
    new TuberTopping { Id = 32, TuberOrderId = 14, ToppingId = 10 },
    new TuberTopping { Id = 33, TuberOrderId = 15, ToppingId = 7 },
    new TuberTopping { Id = 34, TuberOrderId = 15, ToppingId = 10 },
    new TuberTopping { Id = 35, TuberOrderId = 15, ToppingId = 8 },
    new TuberTopping { Id = 36, TuberOrderId = 16, ToppingId = 5 },
    new TuberTopping { Id = 37, TuberOrderId = 16, ToppingId = 6 },
    new TuberTopping { Id = 38, TuberOrderId = 17, ToppingId = 3 },
    new TuberTopping { Id = 39, TuberOrderId = 17, ToppingId = 4 },
    new TuberTopping { Id = 40, TuberOrderId = 17, ToppingId = 2 },
    new TuberTopping { Id = 41, TuberOrderId = 18, ToppingId = 9 },
    new TuberTopping { Id = 42, TuberOrderId = 18, ToppingId = 10 },
    new TuberTopping { Id = 43, TuberOrderId = 19, ToppingId = 7 },
    new TuberTopping { Id = 44, TuberOrderId = 19, ToppingId = 8 },
    new TuberTopping { Id = 45, TuberOrderId = 20, ToppingId = 1 },
    new TuberTopping { Id = 46, TuberOrderId = 20, ToppingId = 2 },
    new TuberTopping { Id = 47, TuberOrderId = 20, ToppingId = 3 },
    new TuberTopping { Id = 48, TuberOrderId = 1, ToppingId = 10 },
    new TuberTopping { Id = 49, TuberOrderId = 2, ToppingId = 1 },
    new TuberTopping { Id = 50, TuberOrderId = 2, ToppingId = 5 },
    new TuberTopping { Id = 51, TuberOrderId = 3, ToppingId = 10 },
    new TuberTopping { Id = 52, TuberOrderId = 4, ToppingId = 6 },
    new TuberTopping { Id = 53, TuberOrderId = 5, ToppingId = 9 },
    new TuberTopping { Id = 54, TuberOrderId = 6, ToppingId = 4 },
    new TuberTopping { Id = 55, TuberOrderId = 7, ToppingId = 5 },
    new TuberTopping { Id = 56, TuberOrderId = 8, ToppingId = 7 },
    new TuberTopping { Id = 57, TuberOrderId = 9, ToppingId = 5 },
    new TuberTopping { Id = 58, TuberOrderId = 10, ToppingId = 6 },
    new TuberTopping { Id = 59, TuberOrderId = 11, ToppingId = 3 },
    new TuberTopping { Id = 60, TuberOrderId = 12, ToppingId = 8 },
    new TuberTopping { Id = 61, TuberOrderId = 13, ToppingId = 6 },
    new TuberTopping { Id = 62, TuberOrderId = 14, ToppingId = 7 },
    new TuberTopping { Id = 63, TuberOrderId = 15, ToppingId = 3 },
    new TuberTopping { Id = 64, TuberOrderId = 16, ToppingId = 2 },
    new TuberTopping { Id = 65, TuberOrderId = 17, ToppingId = 1 },
    new TuberTopping { Id = 66, TuberOrderId = 18, ToppingId = 3 },
    new TuberTopping { Id = 67, TuberOrderId = 19, ToppingId = 4 },
    new TuberTopping { Id = 68, TuberOrderId = 20, ToppingId = 5 },
    new TuberTopping { Id = 69, TuberOrderId = 1, ToppingId = 3 },
    new TuberTopping { Id = 70, TuberOrderId = 2, ToppingId = 7 },
    new TuberTopping { Id = 71, TuberOrderId = 3, ToppingId = 8 },
    new TuberTopping { Id = 72, TuberOrderId = 4, ToppingId = 9 },
    new TuberTopping { Id = 73, TuberOrderId = 5, ToppingId = 1 },
    new TuberTopping { Id = 74, TuberOrderId = 6, ToppingId = 2 },
    new TuberTopping { Id = 75, TuberOrderId = 7, ToppingId = 4 },
    new TuberTopping { Id = 76, TuberOrderId = 8, ToppingId = 6 },
    new TuberTopping { Id = 77, TuberOrderId = 9, ToppingId = 7 },
    new TuberTopping { Id = 78, TuberOrderId = 10, ToppingId = 9 },
    new TuberTopping { Id = 79, TuberOrderId = 11, ToppingId = 10 },
    new TuberTopping { Id = 80, TuberOrderId = 12, ToppingId = 1 },
    new TuberTopping { Id = 81, TuberOrderId = 13, ToppingId = 2 },
    new TuberTopping { Id = 82, TuberOrderId = 14, ToppingId = 4 },
    new TuberTopping { Id = 83, TuberOrderId = 15, ToppingId = 6 }
};

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//add endpoints here

// Get Endpoints
app.MapGet("/tuberorders", () =>
{
    return orders.Select(o =>
    {
        var tops = orderToppings
            .Where(ot => ot.TuberOrderId == o.Id)
            .Select(ot =>
            {
                var topping = toppings.FirstOrDefault(t => t.Id == ot.ToppingId);
                return new ToppingDTO
                {
                    Id = topping.Id,
                    Name = topping.Name
                };
            })
            .ToList();
        return new TuberOrderDTO
        {
            Id = o.Id,
            OrderPlacedOnDate = o.OrderPlacedOnDate,
            CustomerId = o.CustomerId,
            TuberDriverId = o.TuberDriverId,
            DeliveredOnDate = o.DeliveredOnDate,
            Toppings = tops
        };
    });
});

app.MapGet("/tuberorders/{id}", (int id) =>
{
    TuberOrder order = orders.FirstOrDefault(o => o.Id == id);
    var tops = orderToppings
        .Where(ot => ot.TuberOrderId == order.Id)
        .Select(ot =>
        {
            var topping = toppings.FirstOrDefault(t => t.Id == ot.ToppingId);
            return new ToppingDTO
            {
                Id = topping.Id,
                Name = topping.Name
            };
        })
        .ToList();
    return new TuberOrderDTO
    {
        Id = order.Id,
        OrderPlacedOnDate = order.OrderPlacedOnDate,
        CustomerId = order.CustomerId,
        TuberDriverId = order.TuberDriverId,
        DeliveredOnDate = order.DeliveredOnDate,
        Toppings = tops
    };
});

app.MapGet("/toppings", () =>
{
    return toppings.Select(t =>
    {
        return new ToppingDTO
        {
            Id = t.Id,
            Name = t.Name
        };
    });
});

app.MapGet("/toppings/{id}", (int id) =>
{
    Topping topping = toppings.FirstOrDefault(t => t.Id == id);
    return new ToppingDTO
    {
        Id = topping.Id,
        Name = topping.Name
    };
});

app.MapGet("/tubertoppings", () =>
{
    return orderToppings.Select(t =>
    {
        return new TuberToppingDTO
        {
            Id = t.Id,
            TuberOrderId = t.TuberOrderId,
            ToppingId = t.ToppingId
        };
    });
});

app.MapGet("/customers", () =>
{
    return customers.Select(c =>
    {
        var customerOrders = orders
            .Where(o => o.CustomerId == c.Id)
            .Select(o =>
            {
                var tops = orderToppings
                    .Where(ot => ot.TuberOrderId == o.Id)
                    .Select(ot =>
                    {
                        var topping = toppings.FirstOrDefault(t => t.Id == ot.ToppingId);
                        return new ToppingDTO
                        {
                            Id = topping.Id,
                            Name = topping.Name
                        };
                    })
                    .ToList();
                return new TuberOrderDTO
                {
                    Id = o.Id,
                    OrderPlacedOnDate = o.OrderPlacedOnDate,
                    CustomerId = o.CustomerId,
                    TuberDriverId = o.TuberDriverId,
                    DeliveredOnDate = o.DeliveredOnDate,
                    Toppings = tops
                };
            })
            .ToList();
        return new CustomerDTO
        {
            Id = c.Id,
            Name = c.Name,
            Address = c.Address,
            TuberOrders = customerOrders
        };
    });
});

app.MapGet("/customers/{id}", (int id) =>
{
    Customer customer = customers.FirstOrDefault(c => c.Id == id);
    var customerOrders = orders
        .Where(o => o.CustomerId == id)
        .Select(o =>
        {
            var tops = orderToppings
                .Where(ot => ot.TuberOrderId == o.Id)
                .Select(ot =>
                {
                    var topping = toppings.FirstOrDefault(t => t.Id == ot.ToppingId);
                    return new ToppingDTO
                    {
                        Id = topping.Id,
                        Name = topping.Name
                    };
                })
                .ToList();
            return new TuberOrderDTO
            {
                Id = o.Id,
                OrderPlacedOnDate = o.OrderPlacedOnDate,
                CustomerId = o.CustomerId,
                TuberDriverId = o.TuberDriverId,
                DeliveredOnDate = o.DeliveredOnDate,
                Toppings = tops
            };
        })
        .ToList();
    return new CustomerDTO
    {
        Id = customer.Id,
        Name = customer.Name,
        Address = customer.Address,
        TuberOrders = customerOrders
    };
});

app.MapGet("/tuberdrivers", () =>
{
    return drivers.Select(d =>
    {
        var driverDeliveries = orders
            .Where(o => o.TuberDriverId != null)
            .Where(o => o.TuberDriverId == d.Id)
            .Select(o =>
            {
                var tops = orderToppings
                    .Where(ot => ot.TuberOrderId == o.Id)
                    .Select(ot =>
                    {
                        var topping = toppings.FirstOrDefault(t => t.Id == ot.ToppingId);
                        return new ToppingDTO
                        {
                            Id = topping.Id,
                            Name = topping.Name
                        };
                    })
                    .ToList();
                return new TuberOrderDTO
                {
                    Id = o.Id,
                    OrderPlacedOnDate = o.OrderPlacedOnDate,
                    CustomerId = o.CustomerId,
                    TuberDriverId = o.TuberDriverId,
                    DeliveredOnDate = o.DeliveredOnDate,
                    Toppings = tops
                };
            })
            .ToList();
        return new TuberDriverDTO
        {
            Id = d.Id,
            Name = d.Name,
            TuberDeliveries = driverDeliveries
        };
    });
});

app.MapGet("/tuberdrivers/{id}", (int id) =>
{
    TuberDriver driver = drivers.FirstOrDefault(d => d.Id == id);
    var driverDeliveries = orders
        .Where(o => o.TuberDriverId != null)
        .Where(o => o.TuberDriverId == id)
        .Select(o =>
        {
            var tops = orderToppings
                .Where(ot => ot.TuberOrderId == o.Id)
                .Select(ot =>
                {
                    var topping = toppings.FirstOrDefault(t => t.Id == ot.ToppingId);
                    return new ToppingDTO
                    {
                        Id = topping.Id,
                        Name = topping.Name
                    };
                })
                .ToList();
            return new TuberOrderDTO
            {
                Id = o.Id,
                OrderPlacedOnDate = o.OrderPlacedOnDate,
                CustomerId = o.CustomerId,
                TuberDriverId = o.TuberDriverId,
                DeliveredOnDate = o.DeliveredOnDate,
                Toppings = tops
            };
        })
        .ToList();
    return new TuberDriverDTO
    {
        Id = driver.Id,
        Name = driver.Name,
        TuberDeliveries = driverDeliveries
    };
});


// Post Endpoints
app.MapPost("/tuberorders", (TuberOrder order) =>
{
    // create new order
    order.Id = orders.Max(o => o.Id) + 1;
    order.OrderPlacedOnDate = DateTime.Today;
    orders.Add(order);

    // create new order toppings
    foreach (int toppingId in order.TuberToppingIds)
    {
        TuberTopping newTuberTopping = new TuberTopping
        {
            Id = orderToppings.Max(ot => ot.Id) + 1,
            TuberOrderId = order.Id,
            ToppingId = toppingId
        };
        orderToppings.Add(newTuberTopping);
    };

    // find new order toppings
    var tops = orderToppings
        .Where(ot => ot.TuberOrderId == order.Id)
        .Select(ot =>
        {
            var topping = toppings.FirstOrDefault(t => t.Id == ot.ToppingId);
            return new ToppingDTO
            {
                Id = topping.Id,
                Name = topping.Name
            };
        })
        .ToList();

    // return new order
    return Results.Created($"/tuberorders/{order.Id}", new TuberOrderDTO
    {
        Id = order.Id,
        OrderPlacedOnDate = order.OrderPlacedOnDate,
        CustomerId = order.CustomerId,
        TuberDriverId = order.TuberDriverId,
        DeliveredOnDate = order.DeliveredOnDate,
        Toppings = tops
    });
});

app.MapPost("/tuberorders/{id}/complete", (int id) =>
{
    TuberOrder orderToEdit = orders.FirstOrDefault(o => o.Id == id);

    if (orderToEdit == null)
    {
        return Results.BadRequest();
    }

    orderToEdit.DeliveredOnDate = DateTime.Today;

    return Results.NoContent();
});

app.MapPost("/tubertoppings", (TuberTopping topping) =>
{
    topping.Id = orderToppings.Max(t => t.Id) + 1;
    orderToppings.Add(topping);

    return new TuberToppingDTO
    {
        Id = topping.Id,
        TuberOrderId = topping.TuberOrderId,
        ToppingId = topping.ToppingId
    };
});

app.MapPost("/customers", (Customer customer) =>
{
    customer.Id = customers.Max(c => c.Id) + 1;
    customers.Add(customer);

    return new CustomerDTO
    {
        Id = customer.Id,
        Name = customer.Name,
        Address = customer.Address
    };
});

// Put Endpoints
app.MapPut("/tuberorders/{id}", (int id, TuberOrder order) =>
{
    TuberOrder orderToEdit = orders.FirstOrDefault(o => o.Id == id);
    if (orderToEdit == null)
    {
        return Results.NotFound();
    }
    if (id != orderToEdit.Id)
    {
        return Results.BadRequest();
    }

    orderToEdit.TuberDriverId = order.TuberDriverId;

    return Results.NoContent();
});

// Delete Endpoints
app.MapDelete("/tubertoppings/{id}/remove", (int id) =>
{
    TuberTopping toppingToRemove = orderToppings.FirstOrDefault(ot => ot.Id == id);

    if (toppingToRemove == null)
    {
        return Results.BadRequest();
    }

    orderToppings.Remove(toppingToRemove);
    return Results.NoContent();
});

app.MapDelete("/customers/{id}/remove", (int id) =>
{
    Customer customerToRemove = customers.FirstOrDefault(c => c.Id == id);

    if (customerToRemove == null)
    {
        return Results.BadRequest();
    }

    customers.Remove(customerToRemove);
    return Results.NoContent();
});

app.Run();
//don't touch or move this!
public partial class Program { }