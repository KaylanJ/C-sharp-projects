sayHello();

void sayHello(){

    Console.WriteLine("Said hello");
}

float[] arr = {3.2f, 9.9f, 11f, 35.3f};

printArray(arr);

void printArray(float[] array){

    foreach(float x in array){

        Console.WriteLine(x);
    }
}

Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers() 
{
    Random random = new Random();

    for (int i = 0; i < 5; i++) 
    {
        Console.Write($"{random.Next(1, 100)} ");
    }

    Console.WriteLine();
}