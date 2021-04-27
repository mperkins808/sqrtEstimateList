# sqrtEstimateList
Creates a list of Square roots starting from a chosen value and calculates and stores the chosen starting value and increments to a limit.
Can be used for the start of a world generation. Accuracy can be determined by the user.
@@@@@@@@ WRITTEN IN C# BUT CAN EASILY BE PORTED @@@@@@@@
The main function used is || generateSqrtList(double input, int roundTo, int size, double interval)
input: Starting value to start list from -- Cannot be less than zero
roundTo: Utilizes Math.Round to round to the values to number of figures
size: Value that list will reach -- Cannot be less than zero or less than input
interval: difference in size of x1 and x2.

The index of each square root does not need to be stored. Is simply calculated using: Index = (SqrtToFind-Input) / Interval --> We then round to the nearest whole number
Very space efficent. Dont need to store location of each square root. 
@@@@@@@@@@@ EXAMPLE @@@@@@@@@@@@
 x = Convert.ToDouble(Console.ReadLine());        || Grabs a User value 
 sqrtList = s.generateSqrtList(x, 6, 1000, 0.01); || Creates list from user value, rounded to 6 figures, upper bound of 1000, creating a new entry at every 0.01 interval 
 string route = @"DIRECTORY\root.txt";            || The following code outputs a txt file with the list
 using (StreamWriter sw = new StreamWriter(route)
 {
    for (int i = 0; i < sqrtList.Count; i++)
    {
        sw.Write(sqrtList[i].ToString());
    }
 }
 @@ THE FOLLING TEXT FILE @@
 Has 1000 / 0.01 entries --> 100,000 entries.
 File is only 850KB 
