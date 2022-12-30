using ISpan.ReadBooks.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.ReadBooks
{
    public class Book
    {
        public string Title { get; }
        private string[] _content;

        public Book(string title, string content)
        {
            // pre conditions
            if (string.IsNullOrEmpty(title)) throw new ArgumentNullException("title");

            Title = title;

            if (string.IsNullOrEmpty(content))
            {
                _content = Array.Empty<string>();
            }
            else
            {
                _content = content.Replace("\r", string.Empty).Split('\n');
            }

        }

        /// <summary>
        /// what-取得單頁內容
        /// how -計算開始/結束的index,且不可以超過 _content範圍; 傳回此區間內的內容 
        /// </summary>
        /// <param name="pageIndex">想檢視的頁碼,從 0 開始</param>
        /// <param name="pageLength">每頁行數</param>
        /// <returns></returns>
        public string GetPagedContent(int pageIndex, int pageLength)
        {
            // pre conditions
            pageIndex = pageIndex > 0 ? pageIndex : 0;
            pageLength = pageLength > 0 ? pageLength : 1;

            int beginIndex = pageIndex * pageLength;
            int endIndex = beginIndex + pageLength - 1;

            //防止數值不在陣列區間
            beginIndex = beginIndex.EnsureInRange(0, _content.Length - 1);
            endIndex = endIndex.EnsureInRange(0, _content.Length - 1);

            //防止begin,end大小相反
            (int begin, int end) range = (beginIndex, endIndex).EnsureInOrder();
            beginIndex = range.begin;
            endIndex = range.end;


            //int beginIndex = Math.Min(pageIndex * pageLength, _content.Length - 1);
            //int endIndex = Math.Min(beginIndex + pageLength - 1, _content.Length - 1);

            string[] singlePage = _content.GetSubArray(beginIndex, endIndex);
            string content = singlePage.Concat("\r\n");
            
            return content;




            //StringBuilder sb = new StringBuilder();
            //for (int idx = beginIndex; idx <= endIndex; idx++)
            //{
            //	sb.AppendLine(_content[idx]);
            //}

            //return sb.ToString();
        }

    }
}
