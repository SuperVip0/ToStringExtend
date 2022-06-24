using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace WebApi.Filters
{
    public class WebApiExceptionAttribute : FilterAttribute, IExceptionFilter
    {
        public async Task ExecuteExceptionFilterAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            string arguments = "";
            foreach (var item in actionExecutedContext.ActionContext.ActionArguments)
            {
                arguments = item.Key + ":" + item.Value.ToString() + ",";
            }
            arguments = arguments.Substring(0, arguments.Length - 1);
            string errorMsg = actionExecutedContext.Exception.ToString();
            using (StreamWriter writer = File.AppendText(AppDomain.CurrentDomain.BaseDirectory + DateTime.Now.ToString("yyyy-MM-dd") + "err.txt"))
            {
                await writer.WriteLineAsync(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                await writer.WriteLineAsync(actionExecutedContext.Request.RequestUri.ToString());
                await writer.WriteLineAsync(arguments);
                await writer.WriteLineAsync(errorMsg);
            }
        }
    }
}