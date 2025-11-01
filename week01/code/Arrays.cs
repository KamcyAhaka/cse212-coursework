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

        // PLAN:
        // Step 1: Create a new array of doubles with size 'length'
        // Step 2: Loop through the array from index 0 to length-1
        // Step 3: For each index, it calculates the multiple by multiplying number by (index + 1)
        //         - Index 0 gets number * 1 = number
        //         - Index 1 gets number * 2 = number * 2
        //         - Index 2 gets number * 3 = number * 3
        // Step 4: Store each calculated multiple in the array at the current index
        // Step 5: Return the completed array

        // Implementation:
        double[] multiples = new double[length];

        for (int index = 0; index < length; index++)
        {
            multiples[index] = number * (index + 1);
        }

        return multiples;
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

        // PLAN:
        // Step 1: Calculate the split point where we need to divide the list
        //         - If we rotate right by 'amount', the last 'amount' elements move to the front
        //         - Split point = data.Count - amount
        //         - Example: {1,2,3,4,5,6,7,8,9} rotated right by 3
        //           Split point = 9 - 3 = 6
        //           Last 3 elements {7,8,9} should move to front
        // 
        // Step 2: Extract the last 'amount' elements that will move to the front
        //         - Use GetRange(splitPoint, amount) to get elements from splitPoint to end
        //
        // Step 3: Extract the remaining elements that will move to the back
        //         - Use GetRange(0, splitPoint) to get elements from start to splitPoint
        //
        // Step 4: Clear the original list
        //         - Use Clear() to empty the list
        //
        // Step 5: Add the last 'amount' elements first (they rotated to the front)
        //         - Use AddRange() to add the elements we extracted in Step 2
        //
        // Step 6: Add the remaining elements after (they rotated to the back)
        //         - Use AddRange() to add the elements we extracted in Step 3

        // Implementation:
        int splitPoint = data.Count - amount;

        // Get the last 'amount' elements that will move to front
        List<int> elementsToFront = data.GetRange(splitPoint, amount);

        // Get the first elements that will move to back
        List<int> elementsToBack = data.GetRange(0, splitPoint);

        // Clear the original list
        data.Clear();

        // Add elements in rotated order
        data.AddRange(elementsToFront);  // Add the last elements first
        data.AddRange(elementsToBack);   // Add the first elements last
    }
}
