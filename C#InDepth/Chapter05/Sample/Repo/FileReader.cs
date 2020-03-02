using Newtonsoft.Json;
using System.Collections.Generic;
using Sample.Business;
using System.IO;
using System.Threading.Tasks;
using System;

namespace Sample.Repo
{
    public class FileReader : IFileReader
    {
        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            Console.WriteLine("Reading File...");
            var text = await File.ReadAllTextAsync("SampleData.json");

            Console.WriteLine("Reading done");
            
            return JsonConvert
                .DeserializeObject<BookSet>(text)
                .Books;
        }
    }
}