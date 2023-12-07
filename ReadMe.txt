/tuberorders
    Get all orders

        Get:
        https://localhost:7075/tuberorders

    Get an order by id (must include customer data as well as driver and toppings data, if applicable).

        Get:
        https://localhost:7075/tuberorders/15

    Submit a new order (the API should add an OrderPlacedOnDate). Return the new order so the client can see the new Id.

        Post:
        https://localhost:7075/tuberorders
        
        Body:
        {
                "customerId": 1,
                "tuberToppingIds": [1,2,3]
        }

    Assign a driver to an order (PUT to /tuberorders/{id})

        Put:
        https://localhost:7075/tuberorders/21

        Body:
        {
                "tuberDriverId": 3
        }

    Complete an order (POST to /tuberorders/{id}/complete)

        https://localhost:7075/tuberorders/20/complete

/toppings
    Get all toppings

        Get:
        https://localhost:7075/toppings

    Get topping by id
        Get:
        https://localhost:7075/toppings/5

    /tubertoppings
    Get all TuberToppings
        
        Get:
        https://localhost:7075/tubertoppings

    Add a topping to a TuberOrder (return the new TuberTopping object to the client)
        
        Post:
        https://localhost:7075/tubertoppings

        Body:
        {
                "tuberOrderId": 3,
                "toppingId": 1
        }

    Remove a topping from a TuberOrder

        Delete (from order 15):
        https://localhost:7075/tubertoppings/83/remove

/customers
    Get all customers
        
        Get:
        https://localhost:7075/customers

    Get a customer by id, with their orders

        Get:
        https://localhost:7075/customers/5

    Add a customer
        
        Post:
        https://localhost:7075/customers
        
        Body:
        {
                "name": "Josh",
                "Address": "123 Somewhere"
        }

    Delete a customer
        
        Delete:
        https://localhost:7075/customers/2/remove

/tuberdrivers
    Get all drivers

        Get:
        https://localhost:7075/tuberdrivers

    Get a driver by id with their deliveries
        
        Get:
        https://localhost:7075/tuberdrivers/1