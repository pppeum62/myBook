using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBook
{
    class myBook
    {
        public string name;
        public string publish;
        public string writer;
        public string publisher;
        public string publishingCompany;
        public string chief;
        public string planner;
        public string editor;
        public string designer;
    }
    class Program
    {
        static void Main(string[] args)
        {
            myBook mybook = new myBook() { name = "PHP 프로그래밍 입문", publish = "2013년 5월 20일", writer = "황재호", publisher = "김태헌", publishingCompany = "한빛아카데미(주)", chief = "김현용", planner = "김이화", editor = "김이화", designer = "여동일" };
        }
    }
}
