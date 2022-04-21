namespace myfirstapplication;

/*1.Write a method with no parameters and noreturn type.Write a single dimensional 
 string array of ice cream flavors. Using a foreach loop in your method, print 
 out the results of your array using a Console WriteLine statement.
  
  2.Write a method with no parameters and no return type.Write a two-dimensional 
  array using the int data type.Using the link below, fill in each dimension 
  with the KC Chiefs Regular season scores.The first dimensionwill be the home
  team, while the second dimension will be the away team.Using a foreach loop, 
  print out the results of your array using a Console WriteLine statement.To
  determine whichteam is home and away, the website includes the link to the 
  box score.The link label shows both teams.The first team in the label is 
  the away team.a.https://www.footballdb.com/teams/nfl/kansas-city-chiefs/results/2020
*/


internal class Exercise14
{
    // writing a method for single dimensional array
    public void IceCreamFlavors()
    {
        string[] flavorsArray = { "vanilla", "chocolate", "caramel", "cookie dough" };

        // using a foreach loop to pring out the icecream flavors
        foreach(string flavor in flavorsArray)
        {
            Console.WriteLine(flavor);
        }
    } // end method

    // writing a method for the multi dimensional array for the Chiefs football scores
    public void FootballScore()
    {
        // The scores, team 1 is the other team, team 2 is chiefs.
        int[,] chiefScore = new int[,] { { 20, 20, 20, 10, 40, 17, 16, 9, 31, 31,
            24, 16, 27, 29, 14, 38}, {34, 23, 34, 26, 32, 26, 43, 35, 33, 35, 27, 22, 33, 32, 17, 21} };

        // foreach statement and console.writeline to print results
        foreach(int score in chiefScore)
        {
            Console.WriteLine(score);
        }


    }



} // end class
