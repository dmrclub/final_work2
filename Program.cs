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


