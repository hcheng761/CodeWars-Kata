using System;

public class Car : ICar
{
  public IFuelTankDisplay fuelTankDisplay;
  private IEngine engine;
  private IFuelTank fuelTank;

  public Car()
  {
    fuelTank = new FuelTank();
    engine = new Engine(fuelTank);
    fuelTankDisplay = new FuelTankDisplay(fuelTank);

    fuelTank.Refuel(20);
    engine.Stop();
  }
  
  public Car(double fuelLevel)
  {
    fuelTank = new FuelTank();
    engine = new Engine(fuelTank);   
    fuelTankDisplay = new FuelTankDisplay(fuelTank);
    
    if (fuelLevel >= 60)
      this.fuelTank.Refuel(60);
    else
      fuelTank.Refuel(fuelLevel);
    engine.Stop();
  }
  public bool EngineIsRunning { get { return this.engine.IsRunning;} }
  public void EngineStart() { engine.Start();}
  public void EngineStop(){ engine.Stop();}
  public void Refuel(double liters) { fuelTank.Refuel(liters);}
  public void RunningIdle() { engine.Consume(0.0003);}
}

public class Engine : IEngine
{
  public bool running;
  private IFuelTank _fuelTank;
  
  public Engine(IFuelTank fuelTank) { _fuelTank = fuelTank;}
  public bool IsRunning { get { return running; } }
  public void Consume(double liters) { 
    if (running)
      _fuelTank.Consume(liters);
    if (_fuelTank.FillLevel == 0)
      this.Stop();
  }
  public void Start() { 
    if (running == false && _fuelTank.FillLevel > 0)
      running = true; 
  }
  public void Stop() { 
    if (running == true || _fuelTank.FillLevel == 0)
      running = false; 
  }
}

public class FuelTank : IFuelTank
{
  private double tank;
  public double FillLevel { get{ return tank;} }
  public bool IsOnReserve { 
  get { 
    if (tank < 5)
      return true;
    return false;
    } 
  }
  public bool IsComplete { 
    get {
      if (tank == 60)
        return true;
      return false;
    } 
  }
  public void Consume(double liters) 
  {
    tank -= liters;
    tank = Math.Round(tank, 10);
    if (tank < 0)
      tank = 0;
  }
  public void Refuel(double liters) {
    if (liters + tank >= 60)
      tank = 60;
    else
      tank += liters;
  }   
}

public class FuelTankDisplay : IFuelTankDisplay
{
  private IFuelTank _fuelTank;
  public FuelTankDisplay(IFuelTank fuelTank) { _fuelTank = fuelTank;}
  public double FillLevel { get { return Math.Round(_fuelTank.FillLevel, 2);}}
  public bool IsOnReserve { get { return _fuelTank.IsOnReserve;} }
  public bool IsComplete{ get { return _fuelTank.IsComplete;} }
}
