
using System;

public class SingleRouteResponse
{
    public string type { get; set; }
    public string id { get; set; }
    public string name { get; set; }
    public string modeName { get; set; }
    public object[] disruptions { get; set; }
    public DateTime created { get; set; }
    public DateTime modified { get; set; }
    public object[] lineStatuses { get; set; }
    public Routesection[] routeSections { get; set; }
    public Servicetype[] serviceTypes { get; set; }
    public Crowding crowding { get; set; }
    public int status { get; set; }
}

public class Crowding
{
    public string type { get; set; }
}

public class Routesection
{
    public string type { get; set; }
    public string name { get; set; }
    public string direction { get; set; }
    public string originationName { get; set; }
    public string destinationName { get; set; }
    public string originator { get; set; }
    public string destination { get; set; }
    public string serviceType { get; set; }
    public DateTime validTo { get; set; }
    public DateTime validFrom { get; set; }
}

public class Servicetype
{
    public string type { get; set; }
    public string name { get; set; }
    public string uri { get; set; }
}
