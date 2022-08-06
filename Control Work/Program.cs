Console.WriteLine();
 void ZadachaСW()
 {
    
    string[] array= {"1234", "-2","Это", "1567", "был", "о с", "лож", "computer science", "но!", ":("};
    int sizenewarray = CountNumber(array);
    string[] newarray=new string[sizenewarray];
    Console.WriteLine("Вывод массива:");
    PrintArray(array);
    ChangeArray(array, newarray);      
    PrintArray(newarray);
 }
 

 void PrintArray(string[] array)
 {
    Console.WriteLine();
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
 }    
 void ChangeArray(string[] array,string[] newarray)
 {
    int chek =0;
    Console.WriteLine();
    Console.WriteLine("Вывод измененного массива:");
    for (int i = 0; i < array.Length; i++)
    {
      if  (array[i].Length <= 3)
      {
          newarray[chek]=array[i];
          chek++;
      }
      
    }
 }    
 int CountNumber(string[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3) 
    count++;
  }
  return count;
}
ZadachaСW();

