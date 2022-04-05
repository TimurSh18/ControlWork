// Контрольная работа

string [] wordsGiven = new string[] {"Cat", "Table", "132", "Independence", "Cup"};
string [] wordsNeeded = new string [5];

for (int i = 0; i < wordsGiven.Length; i++)
{
    if(wordsGiven[i].Length <= 3)
    {
        {
            wordsNeeded[i] = wordsGiven[i];
            Console.WriteLine(wordsNeeded[i]);  
        }
    }

}


