public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // My plan is simple, I will make a array called results and his capacity will be the value of lengt and this array will be for store the result 
        // of the function and return that and variable int called index that will be used for add the values to the array results and after each loop will incres in one, 
        // after that I will make a for wiht a variable called i and his initial value will be 1 and after each loop will sum 1 to i and a verificator to chek if the value 
        // of i is less or equal that the value of lengt, inside of the for I will put first a variable that will be named product and his value will be the number multiplayed for
        // i and afther that a code for add the value of product incide of the array results using also the variable index and in the end of the function will return results.
        var results = new double [length];
        int index = 0;
        for (int i = 1; i <= length; i++)
        {
            double product = number * i;
            results[index] = product;
            index++;
        }
        return results; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // This time I decide first select the index of the last element of the data an store that in a variable named rotateIndex, after that make a for loop and i that lop
        // create a variable named itemsRotate for store the number in amount and put that number in a countdown for rotate only the necesary number of elements
        // and incide that function is the metod of rotated, fist the code thaque the last item of the data and store in avariable called rotateItem, afther that the code 
        // removes that item of the list and insert that item again in the list but now in the begining of the list, and the fort loop make that this proces is repeated the 
        // number of times necessary for rotate correctly the list that is guiveng to the function in vase of amount.
        var rotateIndex = data.Count-1;
        for (var itemsRotate = amount; itemsRotate > 0; itemsRotate--)
        {
            var rotateItem = data[rotateIndex];
            data.RemoveAt(rotateIndex);
            data.Insert(0, rotateItem);
        }
    }
}
