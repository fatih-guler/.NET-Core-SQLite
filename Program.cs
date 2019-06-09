using System;

namespace NETCore_SQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var _context = new BloggingContext())
            {
                _context.Blogs.Add(new Blog{ Url = "www.github.com"});
                var count = _context.SaveChanges();
                Console.WriteLine("{0} kayıt veritabanına eklendi", count);

                Console.WriteLine();
                foreach (var blog in _context.Blogs)
                {
                    Console.WriteLine(" - {0}", blog.Url);
                }
            }
            Console.ReadKey();
        }
    }
}
