//             0  1  2  3  4  5  6  7  8   9
int [] array={676,24,53,55,74,53,46,72,58,29};

int n=array.Length;
int find=55;
int index=0;


while (index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break; 
    }
          
                
         
    // index=index+1
    index++;
    
}
