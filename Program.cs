// 
string [] SpecifStrArray = {"lincol","dif","ar","mur","duncan","rom","in"};

uint NumbersOfCells = 0;

for (int i = 0; i < SpecifStrArray.Length; i++)
{
    if (SpecifStrArray[i].Length<=3)
    {
        NumbersOfCells ++;
    }
}
string [] ValidStrArray = new string [NumbersOfCells];

for (int i = 0, j=0; i < SpecifStrArray.Length; i++)

{
    if (SpecifStrArray[i].Length<=3)
    {
        ValidStrArray[j] = SpecifStrArray[i];
        j++;
    }
    
}
void PrintArray (string[]array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]}   ");
    }

}
PrintArray(ValidStrArray);
Console.WriteLine();
