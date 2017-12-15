using System;
using System.Collections.Generic;

public class TextMsgSend
{
    public static void Send(object source, PersonEventArgs e)
    {
        TextMessageList = e.Name;
    }

    private static string _textMsgList = "";
    public static string TextMessageList
    {
        get { return _textMsgList; }
        set
        {
            if (_textMsgList == "") {
                _textMsgList += value;
            }
            else
            {
                _textMsgList += ", " + value;
            }
        }
    }
}

    public class PersonEventArgs : EventArgs
    {
        public string Name { get; set; }
    }

    public class Publisher
    {
        public delegate void ContactEventHandler(object sender, PersonEventArgs e);
        public event ContactEventHandler ContactNotify;
        
        public void CountMessages(List<string> peopleList)
        {
            Dictionary<string, int> counter = new Dictionary<string, int>();
            foreach (string person in peopleList)
            {
                if (counter.ContainsKey(person))
                {
                    counter[person] += 1;
                    if (counter[person] % 3 == 0) 
                    {
                      ContactNotify(this, new PersonEventArgs { Name = person});
                    }
                }
                else
                {
                    counter.Add(person, 1);
                }
            }
        }
    }
