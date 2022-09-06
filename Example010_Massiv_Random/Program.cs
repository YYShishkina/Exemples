// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
void FillArray(int[] collection)
{
    int length=collection.Length;
    int index=0;
    while(index<length)
    {
        collection[index]=new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count=col.Length;
    int position=0;
    while (position<count)
    {
         Console.Write($"{col[position]}, ");
         position++;
    }
    
}

int Index0f(int[] collection, int find)
{
    int index=0;
    int position=-1;
    int count=collection.Length;
    while (index<count)
    {
        if (collection[index]==find)
        {
            position = index;
            break;
            //Console.WriteLine(index);
        }
        index++;
    }
    return position;
}
int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = Index0f(array, 4);
Console.WriteLine(pos);