namespace CSharp_Practice.CodingQuestions.SQL_Queries
{
    public class SQLSortAges
    {
        /*In this SQL challenge, your query should return the rows from your table where LastName = Smith or FirstName = Robert and the rows
          should be sorted by age in ascending order. Your output should be look like the below table:-
           |ID|FirstName|LastName|Age|
           |2 |Mike     |Smith   |22 |
           |4 |Robert   |Black   |22 |
           |1 |Daniel   |Smith   |25 |
       */

        /*
         SELECT * FROM TableName WHERE FirstName = 'Robert' And LastName = 'Black' ORDER BY Age; 
        */

        /*First we should filter and fetch all records with FirstName = 'Robert' and LastName = 'Black' then sort by age in ascending
          order. I did not write Order By age asc keyword because SQL queries by default sort in ascending order.
         */
    }
}