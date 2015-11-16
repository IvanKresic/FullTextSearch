# FullTextSearch
Desktop application (C#) for text insertion and text search with PostGreSQL database.


********************************************** Full Text Search **********************************************************

This project is based on C# desktop application, with PostgreSQL database. PostgreSQL is used in order to eneable text search
using features PostgreSQL provides. 

The application provides several options. 
On start you need to enter parameters for your connection string. You need to enter correct values for:

 - IP address of database
 - Port 
 - User ID (username)
 - Password
 - Database name
 
If you entered right values, on "connect" button click you will get message that you are connected to database. Otherwise you 
will get message that you can not establish connection and that you need to check your parameters. 
 
<b>NOTICE: </b>
    I left my hardcoded connectionstring values, so you can have it as example. If you try to connect with that connection 
    string you won't be able to establish connection becouse database on that IP adress does not exist, it was made localy 
    in virtual machine for testing purposes. Change parameters to fit to your database.

Once you are connected, you can insert text into database in "Add data to database" section. Clicking "Add to database" 
button you will recieve messege if your text is inserted into database successfuly. 

You can search text in your database by typing text you want to search in "Search" section and clicking "Search" button.
Also you have some configuration buttons so you can search the way you want. 
Configuration buttons are:

 - AND 
 - OR
 - Exact string matching
 - Use dictionaries
 - Fuzzy string matching
 
Buttons AND and OR, decides how the query will be created with your text you want to search. If you enter text like 
this to search: "Legend of Tarzan" "Lord of" Dance (including quotation marks), and select AND operator, the query will be
formated similar to: Legend of Tarzan AND Lord of AND Dance (when OR is selected, AND is replaced with OR operator).

Configuration buttons "Exact string matching", "Use dictionaries", "Fuzzy string matching", are used to change 
searching algorithms. 

"Exact string matching" - uses operator LIKE %string%

"Use dictionaries" - uses ts_vector (text in database is normalized, and it search by indexes), for more information 
    you can check at PostgreSQL documentation: http://www.postgresql.org/docs/8.3/static/datatype-textsearch.html
    
"Fuzzy string matching" - uses "trigram" algorithm to find results

You are able to search phrases like: "Legend of Tarzan" "Lord of" Dance

In analysis section you are able to select what kind of granulation you want by day or hour. Every time you search for some
text, text you entered is saved with timestamp. So it would be possible to analyse which text is searched most in what
time of the day (by hour), or by dates.
 
 
