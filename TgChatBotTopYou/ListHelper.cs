using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using ServiceStack;
using System.Data.SqlClient;
using System.Web;
using System.Web.Mvc;

namespace TgChatBotTopYou
{
    public static class ListHelper
    {
        public static HtmlString CreateList(this IHtmlHelper html, string[] items)
        {
            string result = "<ul id=\"messagesList\">"; //создаем хелпер списка
            foreach (string item in items)
            {
                result += $"{result}<li>{item}</li>"; //в список записываем элемент с сообщением
            }
            result = $"{result}</ul>";
            return new HtmlString(result);
        }
    }
}
