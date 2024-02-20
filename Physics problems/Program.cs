
double gravity = 7.69;

solution freefrall = new solution(gravity);

// Here you take the time of fall in seconds
Console.Write("Enter drop time in seconds: ");
double time = Convert.ToDouble(Console.ReadLine());

// Here is the operation of calculating the final operation
double finalspeed = freefrall.finaldistance(time);
Console.WriteLine();
Console.WriteLine("The final velocity of the object in free fall is :"+ finalspeed); //Result
Console.ReadLine();