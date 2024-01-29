int A(int m, int n){ //Тут я проверил только аргумент m = 2, n = 3.
    if(m == 0){return n + 1;}
    if(m > 0 && n == 0){return A(m - 1, 1);}
    return A(m-1, A(m, n-1));
}
Console.WriteLine(A(2, 3));