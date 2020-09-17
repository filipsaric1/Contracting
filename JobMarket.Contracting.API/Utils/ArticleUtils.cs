using JobMarket.Contracting.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobMarket.Contracting.API.Utils
{
    public static class ArticleUtils
    {
        public static string GetArticleContent(Article article, string placeholdersJson)
        {
            var articleContent = article.Content;
            var placeholderData = JsonConvert.DeserializeObject<Dictionary<string, string>>(placeholdersJson);

            foreach (var item in article.Placeholders)
            {
                var tmpText = item.Name.Substring(1);
                var tmpText2 = tmpText.Substring(0, tmpText.Length - 1);
                var placeholderPattern = @$"\[({tmpText2})\]";
                string placeholderValue = placeholderData[item.Name];
                var tmpContent = System.Text.RegularExpressions.Regex.Replace(articleContent, placeholderPattern, placeholderValue);
                articleContent = tmpContent;
            }

            return articleContent;
        }
    }
}
