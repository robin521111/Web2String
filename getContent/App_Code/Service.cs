using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Policy;
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

	public string GetWebContent(string url)
	{

        if (string.IsNullOrEmpty(url))
        {
            return null;
        }
        //string sContent = null;
        try
        {


            WebClient channel = new WebClient(); // create a channel

            String sContent = channel.DownloadString(url); // return byte array
                                                           //Stream strm = new MemoryStream(abc); // convert to mem stream
                                                        
            return sContent;

        }
        catch
        {
            throw new Exception(string.Format("Request url: {0} failed !", url));
        }


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
}
