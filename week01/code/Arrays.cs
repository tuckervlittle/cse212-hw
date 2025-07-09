using System.ComponentModel;

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

        // Create a static array to store the results
        // Create a for loop to iterate through the number (1-number) 
        // In the for loop multiply the number by the index while the index is less than or equal to the count
        var results = new double[length];
        for (int i = 1; i <= length; i++)
        {
            results[i-1] = number * i;
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

        // Use list.count() - 1 to find the length of the list and store that as a variable (0 index)
        // Use a for loop with the amount as how many iterations to loop through
        // Store the last item as a variable using list[index]
        // Use list.RemoveAt(index) to remove the last item
        // Use list.insert(0, variable) to add the number to the front
        int indexOfLast = data.Count() - 1;
        for (int i = 0; i < amount; i++)
        {
            int last = data[indexOfLast];
            data.RemoveAt(indexOfLast);
            data.Insert(0, last);
        }
    }
}
