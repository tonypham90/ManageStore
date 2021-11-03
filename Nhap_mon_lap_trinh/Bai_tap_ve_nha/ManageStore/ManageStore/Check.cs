using System;

namespace ManageStore
{
    public class Check
    {
        //kiem tra gia tri trung lap
        public static bool Duplicatecheckid(string value, Item[] items)
        {
            int count = 0;
            bool check = false;
            if (items != null)
                foreach (var element in items)
                    if (element.Id == value)
                        count += 1;

            if (count > 0) check = true;

            return check;
        }
        //kiem tra gia tri loai hang trung lap dung cho them lable moi
        public static bool DuplicatecheckLable(string value, Store data)
        {
            int count = 0;
            bool check = false;
            if (data.Label != null)
                foreach (var element in data.Label)
                    if (element == value)
                        count += 1;

            if (count > 0) check = true;

            return check;
        }
        // tim ky tu
        public static bool Findvalue(string valuelookup, string intext, bool firstlettereachword)
        {
            bool content = false;
            string textcompare;
            valuelookup = valuelookup.ToUpper();
            intext = intext.ToUpper();
            switch (firstlettereachword)
            { 
                case false:
                    int index;
                    for (int i = 0; i < intext.Length-valuelookup.Length; i++)
                    {
                        textcompare = null;
                        if (intext[i]==valuelookup[0])
                        {
                            
                            for (int j = 0; j < valuelookup.Length; j++)
                            {
                                textcompare += intext[i+j];
                            }
                        }

                        content = textcompare == valuelookup;
                        if (content)
                        {
                            break;
                        }
                    }
                    break;
                case true:
                    string[] listword = intext.Split(" ");
                    string textfirstletter = null;
                    foreach (var word in listword)
                    {
                        textfirstletter += word[0].ToString();
                    }
                    for (int i = 0; i < textfirstletter.Length-valuelookup.Length; i++)
                    {
                        textcompare = null;
                        if (textfirstletter[i]==valuelookup[0])
                        {
                            for (int j = 0; j < valuelookup.Length; j++)
                            {
                                textcompare += textfirstletter[i+j];
                            }
                        }
                        content = textcompare == valuelookup;
                        if (content)
                        {
                            break;
                        }
                    }
                    break;
            }

            return content;
        }
        

    }
}