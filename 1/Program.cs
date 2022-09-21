Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int [] array=  new int[n];

for (int i=0; i<array.Length; i++)
    array[i] =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("["+string.Join(", ",array)+ "]");


    int count =0;

for (int i=0; i<array.Length; i++)
if (array[i]>0)
    count++;

Console.WriteLine("Число элементов больше нуля: "+count);


