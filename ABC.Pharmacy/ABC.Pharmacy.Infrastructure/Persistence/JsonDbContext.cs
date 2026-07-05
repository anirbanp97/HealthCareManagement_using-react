using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Infrastructure.Persistence
{
    public class JsonDbContext
    {

        private readonly string _basePath;


        public JsonDbContext()
        {

            _basePath = Path.Combine(
                AppContext.BaseDirectory,
                "Persistence",
                "Json"
            );


            if (!Directory.Exists(_basePath))
            {
                Directory.CreateDirectory(_basePath);
            }

        }




        public async Task<List<T>> ReadAsync<T>(
            string fileName)
        {


            var path = Path.Combine(
                _basePath,
                fileName
            );



            if (!File.Exists(path))
            {

                await File.WriteAllTextAsync(
                    path,
                    "[]"
                );

            }



            var json =
                await File.ReadAllTextAsync(path);



            if (string.IsNullOrWhiteSpace(json))
            {
                return new List<T>();
            }




            return JsonSerializer.Deserialize<List<T>>(json)
                   ?? new List<T>();

        }






        public async Task WriteAsync<T>(
            string fileName,
            List<T> data)
        {



            var path = Path.Combine(
                _basePath,
                fileName
            );



            var json =
                JsonSerializer.Serialize(
                    data,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });



            await File.WriteAllTextAsync(
                path,
                json
            );

        }


    }
}
