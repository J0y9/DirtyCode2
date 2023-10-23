using DirtyCode2;

var arr1 = new ArrayOperations<double>(5)
{
    MyArray = new[] { 1.0, 2, 3, 4, 5 }
};
arr1.Print();
arr1.Max();
arr1.Average();
ArrayOperations<double> arr2 = new(5)
{
    MyArray = new[] { 1.0, 2, 3, 4, 5 }
};
arr2.Print();
arr2.Max();
arr2.Average();

var result = ArrayOperations<double>.SumTwoArrays(arr1.MyArray, arr2.MyArray);

ArrayOperations<double> arr3 = new(5);
arr3.MyArray = result;
arr3.Print();
arr3.Max();
arr3.Average();