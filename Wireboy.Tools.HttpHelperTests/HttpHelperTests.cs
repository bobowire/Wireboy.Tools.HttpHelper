using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wireboy.Tools.HttpHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wireboy.Tools.HttpHelper.Tests
{
    [TestClass()]
    public class HttpHelperTests
    {
        [TestMethod()]
        public void GetHtmlTest()
        {
            HttpHelper httpHelper = new HttpHelper();
            HttpItem httpItem = new HttpItem();
            httpItem.URL = "http://www.baidu.com";
            HttpResult result = httpHelper.GetHtml(httpItem);
            Assert.IsNotNull(result.Html.Length);
        }
    }
}