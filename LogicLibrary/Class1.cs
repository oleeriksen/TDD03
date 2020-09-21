using System;
using System.Collections.Generic;
using GeoCoordinatePortable;

namespace LogicLibrary
{


    public class BEShop { }

    public interface Class1
    {

        // Return: all shops in source, sorted according to their distance to location x.
        List<BEShop> SortByDistance(List<BEShop> source, GeoCoordinate x);

        // Return all shops from source located in the rectangle defined by x, width and height,
        // where x is the lower left corner of the rectangle. The unit of width and height is kilometer.
        List<BEShop> FilterByLocation(List<BEShop> source, GeoCoordinate x, int width, int height);

    }
}
