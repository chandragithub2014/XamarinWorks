using System;
using Newtonsoft.Json;

namespace XamarinPractice.model
{
    public class PostUsers
    {
   
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public String Name { get; set; }
        [JsonProperty(PropertyName = "username")]
        public String UserName { get; set; }
        [JsonProperty(PropertyName = "email")]
        public String Email { get; set; }
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        public bool isBusy { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
 }
    

