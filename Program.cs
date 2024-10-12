internal class Program
{
    private static void Main(string[] args)
    {
        int[] myArray ={1,2,3,4,5,6,7,8,9};
        Console.WriteLine("Gia tri lon nhat la {0}",MaxFunc(myArray));
    }
    private static int MaxFunc(int [] arr){
        int max = arr[0];
        for(var i = 0; i < arr.Length;i++){
            if(arr[i] > max){
                max = arr[i];
            }
        }
        return max;
    }
}