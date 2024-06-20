using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.UI.WebControls;

// 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、服务和配置文件中的类名“Service”。
public class Service : IService
{
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public string[] Top10Words(string content)
	{
        
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            string[] filtedwords = content.Split(' ');
            foreach (string word in filtedwords)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            // 按单词出现次数降序排序
            List<KeyValuePair<string, int>> sortedWords = wordCount.OrderByDescending(w => w.Value).ToList();

            // 获取前10个单词
            List<string> top10Words = sortedWords.Take(10).Select(w => w.Key).ToList();

            return top10Words.ToArray();
       
        
    }

	
}
