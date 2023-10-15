//For Loop With Jagged Array

string[] person = new string[3];
person[0] = "Wazed";
person[1] = "Rasel";
person[2] = "Ratul";

string[][] breakFast = new string[3][];

breakFast[0] = new string[3];
breakFast[1] = new string[3];
breakFast[2] = new string[3];

breakFast[0][0] = "Apple";
breakFast[0][1] = "Orange";
breakFast[0][2] = "Banana";

breakFast[1][0] = "Bread";
breakFast[1][1] = "Egg";
breakFast[1][2] = "Dal";

breakFast[2][0] = "Milk";
breakFast[2][1] = "Egg";
breakFast[2][2] = "Pasta";


for(int i = 0; i < breakFast.Length; i++)
{
    string[] arrayElements = breakFast[i];
    Console.WriteLine(person[i]);
    Console.WriteLine("============");

    for(int j = 0; j < arrayElements.Length; j++)
    {
        Console.WriteLine(arrayElements[j]);
        Console.WriteLine();
    }

}

