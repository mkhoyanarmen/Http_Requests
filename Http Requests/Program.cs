using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Http_Requests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("--------------Http GET--------------");
            //using (var client = new HttpClient())
            //{
            //    var endpoint = new Uri("https://jsonplaceholder.typicode.com/posts");
            //    var result = client.GetAsync(endpoint);//Http Get Method
            //    Console.WriteLine(result.Result.Content.ReadAsStringAsync().Result);
            //}

            //Console.WriteLine("--------------Http POST--------------");
            //using (var client = new HttpClient())
            //{
            //    JsonPost post = new JsonPost("Post Title", "Post Body", 5);
            //    var endpoint = new Uri("https://jsonplaceholder.typicode.com/posts");
            //    var content = JsonConvert.SerializeObject(post);
            //    var stringContent = new StringContent(content, Encoding.UTF8, "application/json");
            //    var result = client.PostAsync(endpoint, stringContent);//Http Post Method
            //    Console.WriteLine(result.Result.Content.ReadAsStringAsync().Result);
            //}

            //Console.WriteLine("--------------Http PUT--------------");
            //using (var client = new HttpClient())
            //{
            //    JsonPost post = new JsonPost("Post Title", "Post Body", 5);
            //    var endpoint = new Uri("https://jsonplaceholder.typicode.com/posts/1");
            //    var getResult = client.GetAsync(endpoint);
            //    Console.WriteLine(getResult.Result.Content.ReadAsStringAsync().Result);
            //    var content = JsonConvert.SerializeObject(post);
            //    var stringContent = new StringContent(content, Encoding.UTF8, "application/json");
            //    var result = client.PutAsync(endpoint, stringContent);//Http Put Method
            //    Console.WriteLine(result.Result.Content.ReadAsStringAsync().Result);
            //}

            Console.WriteLine("--------------Http DELETE--------------");
            using (var client = new HttpClient())
            {
                var endpoint = new Uri("https://jsonplaceholder.typicode.com/posts/1");
                var getResult = client.GetAsync(endpoint);
                Console.WriteLine(getResult.Result.Content.ReadAsStringAsync().Result);

                var delete = client.DeleteAsync(endpoint);//Http Delete Method
                Console.WriteLine(delete.Result.Content.ReadAsStringAsync().Result);
            }
        }
    }
}