int[] array = {5, 1, 9, 9, 2, 3, 8, -4, 0}; //Можно поменять массив
void RotateArray(int[] array, int i){
    Console.Write($"{array[array.Length - i - 1]} ");
    i++;
    if(i < array.Length){
        RotateArray(array, i);
    }
}
RotateArray(array, 0);