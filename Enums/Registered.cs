﻿using System.Text.Json.Serialization;

namespace MyPetAppAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Registered 
    {
        Yes,
        No
    }
}
