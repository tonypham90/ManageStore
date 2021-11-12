namespace ManageStore
{
    public class Check
    {
        //kiem tra gia tri trung lap
        public static bool DuplicateCheckId(string value, Item[] items)
        {
            int count = 0;
            bool check = false;
            if (items != null)
                foreach (Item element in items)
                    if (element.Id == value)
                        count += 1;

            if (count > 0) check = true;

            return check;
        }

        //kiem tra gia tri loai hang trung lap dung cho them lable moi
        public static bool DuplicateCheckLabel(string value, Store data)
        {
            int count = 0;
            bool check = false;
            if (data.Label != null)
                foreach (string element in data.Label)
                    if (element == value)
                        count += 1;

            if (count > 0) check = true;

            return check;
        }

        // tim ky tu
        public static bool FindValue(string valueLookup, string inText, bool firstLetterEachWord)
        {
            bool content = false;
            string textcompare;
            valueLookup = valueLookup.ToUpper();
            inText = inText.ToUpper();
            switch (firstLetterEachWord)
            {
                case false:
                    for (int i = 0; i < inText.Length - valueLookup.Length + 1; i++)
                    {
                        textcompare = null;
                        if (inText[i] == valueLookup[0])
                            for (int j = 0; j < valueLookup.Length; j++)
                                textcompare += inText[i + j];


                        if (textcompare == valueLookup)
                        {
                            content = true;
                            break;
                        }
                    }

                    break;
                case true:
                    string[] listword = inText.Split(" ");
                    string textfirstletter = null;
                    foreach (string word in listword) textfirstletter += word[0].ToString();
                    for (int i = 0; i < textfirstletter.Length - valueLookup.Length + 1; i++)
                    {
                        textcompare = null;
                        if (textfirstletter[i] == valueLookup[0])
                            for (int j = 0; j < valueLookup.Length; j++)
                                textcompare += textfirstletter[i + j];
                        content = textcompare == valueLookup;
                        if (content) break;
                    }

                    break;
            }

            return content;
        }
    }
}