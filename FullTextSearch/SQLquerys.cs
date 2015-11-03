using System.Collections.Generic;


namespace FullTextSearch
{
    class SQLquerys
    {

        static string giveMeTheKey;
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
    }
}
