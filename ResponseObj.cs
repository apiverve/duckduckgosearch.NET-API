using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class results
{
    [JsonProperty("title")]
    public string title { get; set; }

    [JsonProperty("url")]
    public string url { get; set; }

    [JsonProperty("description")]
    public string description { get; set; }

}

public class data
{
    [JsonProperty("query")]
    public string query { get; set; }

    [JsonProperty("count")]
    public int count { get; set; }

    [JsonProperty("results")]
    public results[] results { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
