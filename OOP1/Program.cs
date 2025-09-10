//Create two objects from the Marker class
Marker blueMarker = new Marker(); //blue marker using default constructor
Marker blackMarker = new Marker(); //black marker using default constructor
Marker redMarker = new Marker(30, true, "Red"); //red marker using parametrized constructor

//assigning values to the class

//blue marker value
blueMarker.color = "Blue";
blueMarker.isCapOn = true;
blueMarker.inkLevel = 100;
PrintMarkerInfo(blueMarker); //show the marker info

//black marker value
blackMarker.color = "Black";
blackMarker.isCapOn = false;
blackMarker.inkLevel = 50;
PrintMarkerInfo(blackMarker); //show the marker info

//Print the red marker value
PrintMarkerInfo(redMarker);

//This method will take a marker class and print the information
void PrintMarkerInfo(Marker marker)
{
    Console.WriteLine($"Color:{marker.color}");
    Console.WriteLine($"Is Close: {marker.isCapOn}");
    Console.WriteLine($"Ink Level:{marker.inkLevel}%");
    Console.WriteLine(); //space
}



