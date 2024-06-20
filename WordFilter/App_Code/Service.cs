using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、服务和配置文件中的类名“Service”。
public class Service : IService
{
    public string GetData(int value)
    {
        return string.Format("You entered: {0}", value);
    }

    public CompositeType GetDataUsingDataContract(CompositeType composite)
    {
        if (composite == null)
        {
            throw new ArgumentNullException("composite");
        }
        if (composite.BoolValue)
        {
            composite.StringValue += "Suffix";
        }
        return composite;
    }

    public string WordFilter(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return null;
        }

        string[] stopWords = { "a", "an", "in", "on", "the", "is", "are", "am" };

        string[] words = str.Split(' ');


        List<string> filteredWords = new List<string>();

        foreach (string word in words)
        {
            if (!stopWords.Contains(word.ToLower()))
            {
                filteredWords.Add(word);
            }
            else if (stopWords.Contains(word.ToLower()))
            {

            }
        }

        string filteredContent = string.Join(" ", filteredWords);

        return filteredContent;
    }
    public string output(string str)
    {
        string output = string.Empty;
       return output = str;
    }
}
