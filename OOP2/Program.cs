//Create two objects from the Marker class
Marker blueMarker = new Marker(); //blue marker using default constructor
Marker blackMarker = new Marker(); //black marker using default constructor
Marker redMarker = new Marker(30, true, "Red"); //red marker using parametrized constructor


//show the value of the default before changed
PrintMarkerInfo(blueMarker);
//assigning values to the class

//blue marker value
blueMarker.Color = "";
blueMarker.IsCapOn = true;
blueMarker.Ink = -19;
PrintMarkerInfo(blueMarker); //show the marker info

//black marker value
blackMarker.Color = "Black";
blackMarker.IsCapOn = false;
blackMarker.Ink = 20;
PrintMarkerInfo(blackMarker); //show the marker info

//Print the red marker value
PrintMarkerInfo(redMarker);

//This method will take a marker class and print the information
void PrintMarkerInfo(Marker marker)
{
    Console.WriteLine($"Color:{marker.Color}");
    Console.WriteLine($"Is Close: {marker.IsCapOn}");
    Console.WriteLine($"Ink Level:{marker.Ink}%");
    
    Console.WriteLine(); //space
}



