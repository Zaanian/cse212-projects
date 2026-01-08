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

        // Create new array with the length of 'length'.
        //Variable to have number multiply by.
        //Create a loop to run 'length' number of times.
        //Adds a new element into the new array. Each element is a multiple of the 'number'.
        //Increments 'multiply by' variable by 1. So next loop will multiply by 2, then 3, and so on.

        var result = new double[length];
        var y = 1;
        for (var i = 0; i < length; i++)
        {
            result[i] = y * number;
            y++;
        }


        return result; // replace this return statement with your own
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

        //Variable to hold the last index number of the data list
        //Variable to hold the element to be removed from the end of the list and then insert it at the beginnining of the list.
        //Create a loop that will repeat 'amount' number of times.
        //Find the last index.
        //Find the element that goes to the last index.
        //Remove the last element by the last index.
        //Insert the removed element into the beginning of the list.

        var LstIdx = 0;
        var x = 0;
        for (var i = 0; i < amount; i++)
        {
            LstIdx = data.Count - 1;
            x = data[LstIdx];
            data.RemoveAt(LstIdx);
            data.Insert(0, x);

        }

    }
}
