using AMST4_HERANCA_VEICULO.Models;

Car car = new Car();
car.Color = "Preto";
car.Model = "Onix";
car.Seat = 10;

AirPlane airplane = new AirPlane();
airplane.Color = "Preto";
airplane.Model = "Jato";
airplane.Seat = 25;

Console.WriteLine($"{car.Color}, {car.Model}, {car.Seat}");
Console.WriteLine($"{airplane.Color}, {airplane.Model}, {airplane.Seat}");