using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EcoBin_GateWay_Service.Model.DTOs.Responses;
public class DirectionsResponseDto
{
    [JsonPropertyName("routes")]
    public List<Route> Routes { get; set; } = [];

    [JsonPropertyName("waypoints")]
    public List<Waypoint> Waypoints { get; set; } = [];

    [JsonPropertyName("code")]
    public string Code { get; set; } = string.Empty;

    [JsonPropertyName("uuid")]
    public string Uuid { get; set; } = string.Empty;
}

public class Route
{
    [JsonPropertyName("weight_name")]
    public string WeightName { get; set; } = string.Empty;

    [JsonPropertyName("weight")]
    public double Weight { get; set; }

    [JsonPropertyName("duration")]
    public double Duration { get; set; }

    [JsonPropertyName("distance")]
    public double Distance { get; set; }

    [JsonPropertyName("legs")]
    public List<Leg> Legs { get; set; } = [];

    [JsonPropertyName("geometry")]
    public Geometry Geometry { get; set; } = new();
}

public class Leg
{
    [JsonPropertyName("via_waypoints")]
    public List<object> ViaWaypoints { get; set; } = [];

    [JsonPropertyName("admins")]
    public List<Admin> Admins { get; set; } = [];

    [JsonPropertyName("weight")]
    public double Weight { get; set; }

    [JsonPropertyName("duration")]
    public double Duration { get; set; }

    [JsonPropertyName("steps")]
    public List<object> Steps { get; set; } = [];

    [JsonPropertyName("distance")]
    public double Distance { get; set; }

    [JsonPropertyName("summary")]
    public string Summary { get; set; } = string.Empty;
}

public class Admin
{
    [JsonPropertyName("iso_3166_1_alpha3")]
    public string Iso31661Alpha3 { get; set; } = string.Empty;

    [JsonPropertyName("iso_3166_1")]
    public string Iso31661 { get; set; } = string.Empty;
}

public class Geometry
{
    [JsonPropertyName("coordinates")]
    public List<List<double>> Coordinates { get; set; } = [];

    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
}

public class Waypoint
{
    [JsonPropertyName("distance")]
    public double Distance { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("location")]
    public List<double> Location { get; set; } = [];
}