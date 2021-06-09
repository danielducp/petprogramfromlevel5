using System;
namespace PetSimulation
{
     class RoomEnvironment
    {

        public double CurrentRoomTemperature;
        public double roomtemperature;



public RoomEnvironment(double CurrentRoomTemperature)
{
    this.CurrentRoomTemperature = CurrentRoomTemperature;
     roomtemperature = 25; //Default room temperature

}

public void UpdateCurrentTemperature()
{
    if (roomtemperature > CurrentRoomTemperature)
    {
        roomtemperature -= 0.1; //Temperature goes down by this value if too warm
    }
    else if (roomtemperature < CurrentRoomTemperature)
    {
        roomtemperature += 0.1; //Temperature goes up by this value if too cold
    }
}

    public void HeatTheRoom()
    {
        roomtemperature  += 2;  //Temperature goes up by 2 if told to warm up
    }
     public void CoolTheRoom()
    {
        roomtemperature  -= 2; //Temperature goes down by 2 if told to cool down
    }

   
    
}
    }
