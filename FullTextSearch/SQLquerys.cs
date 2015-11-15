using System;
using System.Collections.Generic;


namespace FullTextSearch
{
    class SQLquerys
    {

        static string giveMeTheKey;
        static int tempInt = 1;

        public void setTheKey(string connString)
        {
            giveMeTheKey = connString;
            giveMeTheKey += "";
        }

        public string getTheKey()
        {
            giveMeTheKey += "";
            return giveMeTheKey;
        }

        public void setCounter()
        {
            tempInt = 1;
        }
        public string createFunctionString(List<string> searchList, char selector)
        {
            string TempString = "";
            string[] TempField = null;
            int i = 0;
            int j = 0;

            foreach (string searchStringInList in searchList)
            {
                if (j != 0)
                {
                    if (selector == '+')
                        TempString = TempString + " | ";
                    else if (selector == '*')
                        TempString = TempString + " & ";
                }
                j = 1;
                TempField = this.splitListForInput(searchStringInList);
                TempString = TempString + "(";
                foreach (string justTempString in TempField)
                {
                    if (i != 0)
                    {
                        TempString = TempString + " & ";
                    }
                    TempString = TempString + justTempString;
                    i = 1;
                }
                TempString = TempString + ")";
                i = 0;
            }
            return TempString;
        }


        public List<string> splitInputField(string[] inputField)
        {
            List<string> unfinishedList = new List<string>();

            foreach (string splitString in inputField)
            {
                unfinishedList.Add(splitString);
            }

            return unfinishedList;
        }


        public string[] splitListForInput(string inputString)
        {
            string[] parsedList = null;

            parsedList = inputString.Split(' ');

            return parsedList;
        }


        public string createTsFunction(string tsString)
        {
            string tsHeadline = "";
            string tsRank = "";
            string tsFunction = "";

            tsHeadline = ",\n ts_headline(\"Text\", to_tsquery('" + tsString + "')), \"Text\"";
            tsRank = ",\n ts_rank(to_tsvector(\"Text\"), to_tsquery('" + tsString + "')) rank";
            tsFunction = tsHeadline + tsRank;

            return tsFunction;
        }


        public string createSqlString(List<string> searchList, char selector, char vrstaPretrazivanja)
        {
            string selectString = "";
            string myTempString = "";
            string TempString = "";
            int i = 0;

            TempString = createFunctionString(searchList, selector);
            TempString = createTsFunction(TempString);
            selectString = "SELECT \"ID\"" + TempString + "\nFROM \"textTable\" \nWHERE ";
            if (vrstaPretrazivanja == 'A')
            {
                foreach (string myString in searchList)
                {                   

                    if (i == 0)
                    {
                        myTempString = myTempString + "\"Text\" LIKE '%" + myString + "%' ";
                        i++;
                    }
                    else
                    {
                        if (selector == '*')
                            myTempString = myTempString + "\nAND \"Text\" LIKE '%" + myString + "%' ";
                        else if (selector == '+')
                            myTempString = myTempString + "\nOR \"Text\" LIKE '%" + myString + "%' ";
                    }
                }
            }
            else if (vrstaPretrazivanja == 'B')
            {
                foreach (string myString in searchList)
                {
                    string temporalString = "";
                    string[] testingString = myString.Split(' ');

                    for(int k=0; k < testingString.Length;k++)
                    {
                        if (k != testingString.Length - 1)
                        {
                            temporalString += testingString[k] + " & ";
                        }
                        else
                        {
                            temporalString += testingString[k];
                        }
                    }

                    if (i == 0)
                    {
                        myTempString = myTempString + "to_tsvector(\"Text\") @@ to_tsquery('english', '" + temporalString + "')";
                        i++;
                    }
                    else
                    {
                        if (selector == '*')
                            myTempString = myTempString + "\nAND to_tsvector(\"Text\") @@ to_tsquery('english', '" + temporalString + "')";
                        else if (selector == '+')
                            myTempString = myTempString + "\nOR to_tsvector(\"Text\") @@ to_tsquery('english', '" + temporalString + "')";
                    }
                }
            }
            if (vrstaPretrazivanja == 'C')
            {
                foreach (string myString in searchList)
                {
                    if (i == 0)
                    {
                        myTempString = myTempString + "\"Text\" % '" + myString + "' ";
                        i++;
                    }
                    else
                    {
                        if (selector == '*')
                            myTempString = myTempString + "\nAND \"Text\" % '" + myString + "' ";
                        else if (selector == '+')
                            myTempString = myTempString + "\nOR \"Text\" % '" + myString + "' ";
                    }
                }
            }
            selectString = selectString + myTempString + "\nORDER BY rank DESC";

            return selectString;
        }
         
        public string testIfEmpty(string searchedText)
        {
            string checkingIfEmpty = "SELECT * FROM \"analysisTable\" WHERE \"searchedText\" =' " + searchedText+"'";
            return checkingIfEmpty;
        }

        public string queryForAnalysis(char analysisChoice)
        {
            string myTestsql="";
            if (analysisChoice == 'H')
            {
                myTestsql = "SELECT * FROM crosstab('SELECT CAST((\"searchedText\") AS text) searchedText,"
                            + " CAST(EXTRACT(HOUR FROM \"timeOfSearch\") AS int) AS sat, CAST(COUNT(*) AS int) AS broj FROM \"analysisTable\" GROUP BY \"searchedText\", sat"
                            + " ORDER BY \"searchedText\", sat', 'SELECT rbrSata FROM sat ORDER BY rbrSata') AS pivotTable (\"searchedText\" TEXT, t0_1 INT, t1_2 INT"
                            + ", t2_3 INT, t3_4 INT, t4_5 INT, t5_6 INT, t6_7 INT, t7_8 INT, t8_9 INT, t9_10 INT, t10_11 INT, t11_12 INT, t12_13 INT"
                            + ", t13_14 INT, t14_15 INT, t15_16 INT, t16_17 INT, t17_18 INT, t18_19 INT, t19_20 INT, t20_21 INT, t21_22 INT, t22_23 INT, t23_00 INT) ORDER BY \"searchedText\"";
                return myTestsql;
            }
            else if (analysisChoice == 'D')
            {
                myTestsql += "SELECT *FROM crosstab ('SELECT CAST((\"searchedText\") AS text) AS searchedText, CAST(EXTRACT(DAY FROM \"dateOfSearch\") AS int) AS dan"
                            + ", CAST(COUNT(*) AS int) AS broj FROM \"analysisTable\" GROUP BY \"searchedText\", "
                            + "dan ORDER BY \"searchedText\", dan', 'SELECT rbrDana FROM dan ORDER BY rbrDana') AS pivotTable(\"searchedText\" TEXT";
                return myTestsql;
            }
            else
                return myTestsql;
        }

        public int[] parseForDates(string date)
        {
            string[] temp;
            int[] tempInt =new int[3];
            temp = date.Split('-');
            for(int i = 0; i < 3;i++)
            {
                tempInt[i] = int.Parse(temp[i]);
            }
            return tempInt;
        }

        public string createSqlForDayAnalysis(string dateFrom, string dateTo)
        {
            string insertIntoTempTable = "";
            string dateTimeForAnalysis = "";
            int[] tempFrom = this.parseForDates(dateFrom);
            int[] tempTo = this.parseForDates(dateTo);

            //Algorithm for month changing
            while (tempFrom[0] != tempTo[0] || tempFrom[1] != tempTo[1])
            {

                if (tempFrom[1] == tempTo[1])
                {
                    if (tempFrom[0] != tempTo[0])
                    {
                        for (int i = tempInt + 1; tempFrom[0] + 2 < tempTo[0] + 2; i++)
                        {
                            insertIntoTempTable += "INSERT INTO \"dan\" VALUES (" + i + ");";
                            dateTimeForAnalysis += ",dd" + tempFrom[0] + tempFrom[1] + tempFrom[2]+" INT";
                            tempInt = i;
                            tempFrom[0]++;
                        }
                    }
                }
                if (tempFrom[1] != tempTo[1])
                {
                    if (tempFrom[1] % 2 == 0 || tempFrom[1] == 7 || tempFrom[1] == 1)
                    {
                        for (int i = tempInt; tempFrom[0] < 31 && tempFrom[1] != tempTo[1]; i++)
                        {
                            insertIntoTempTable += "INSERT INTO \"dan\" VALUES (" + i + ");";
                            dateTimeForAnalysis += ", dd" + tempFrom[0]  + tempFrom[1] +  tempFrom[2] + " INT";
                            tempInt = i;
                            tempFrom[0]++;
                            if (tempFrom[0] == 31)
                            {
                                tempFrom[1]++;
                                tempFrom[0] = 1;
                            }
                        }
                         
                    }
                }
            }
            dateTimeForAnalysis += ") ORDER BY \"searchedText\"";
            return dateTimeForAnalysis + "#" + insertIntoTempTable;
        }
    }
}
