// Задача 41:Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.



/*
int ParsePositive(string nums) {
    string[] nums_str = nums.Split(' ');
    int count = 0;
    foreach (string num in nums_str)
    {
        if (Convert.ToInt32(num) > 0){
            count++;
        }

    }
    return count;
}

Console.WriteLine("Enter Numbers");
string nums = Console.ReadLine();
int res = ParsePositive(nums);
Console.Write("Positive numbers count: "+ res); */


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


double[] ParseParams(string nums) {
    string[] nums_str = nums.Split(',');
    double[] pars = new double[4];
    int i = 0;
    foreach (string num in nums_str)
    {
        pars[i]=Convert.ToDouble(num);
        i++;

    }
    return pars;
}

double Det(double a1,double a2, double b1,double b2){
    //a1 b1
    //a2 b2
    return a1*b2-b1*a2;
}

Console.WriteLine("Enter b1,k1,b2,k2 separate with comma");
string param_s = Console.ReadLine();
double[] line_params = ParseParams(param_s);
//b1 k1 b2 k2 
//y = k1 * x + b1 =>  - k1 * x + y = b1
//y = k2 * x + b2 =>  - k2 * x + y = b2

double main_det = Det(line_params[1]*(-1),line_params[3]*(-1),1,1);
double x_det = Det(line_params[0],line_params[2],1,1);
double y_det = Det(line_params[1]*(-1),line_params[3]*(-1),line_params[0],line_params[2]);


if (main_det!=0){
    Console.Write($"Intersection Point ({x_det/main_det};{y_det/main_det})");
}