
int? maybe = 12;


// declaration pattern to test the type of variable and assign it to new variable
if(maybe is int number)
{
    Console.WriteLine($"The nullable int 'maybe' has the value {number}");
} else
{
    Console.WriteLine("The nullable int 'maybe' doesn't hold a value");
}


string? message = "This is not the null string";


// check that varibale is not null
// constant pattern to compare with `null` and with logical pattern `not` that matches when negated pattern doesn't match
if(message is not null)
{
    Console.WriteLine(message);
}

string WaterState(int tempInFahrenheit) =>
    tempInFahrenheit switch
    {
        (> 32) and (< 212) => "liquid",
        < 32 => "solid",
        > 212 => "gas",
        32 => "solid/liquid transition",
        212 => "liquid / gas transition",
    };

string state = WaterState(99);

Console.WriteLine($"Water in 99F has {state} state.");
