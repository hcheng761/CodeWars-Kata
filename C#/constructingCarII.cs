using System;
using System.Collections.Generic;
using System.Linq;
public class Car : ICar
    {
        public IDrivingInformationDisplay drivingInformationDisplay; // car #2  

        private IDrivingProcessor drivingProcessor; // car #2

        public IFuelTankDisplay fuelTankDisplay;

        private IEngine engine;

        private IFuelTank fuelTank;

        public Car()
        {
            fuelTank = new FuelTank();
            fuelTankDisplay = new FuelTankDisplay(fuelTank);
            engine = new Engine(fuelTank);
            drivingProcessor = new DrivingProcessor();
            drivingInformationDisplay = new DrivingInformationDisplay(drivingProcessor);
        }

        public Car(double fuelLevel)
        {
            fuelTank = new FuelTank(fuelLevel);
            fuelTankDisplay = new FuelTankDisplay(fuelTank);
            engine = new Engine(fuelTank);
            drivingProcessor = new DrivingProcessor();
            drivingInformationDisplay = new DrivingInformationDisplay(drivingProcessor);
        }

        public Car(double fuelLevel, int maxAcceleration) // car #2
        {
            fuelTank = new FuelTank(fuelLevel);
            fuelTankDisplay = new FuelTankDisplay(fuelTank);
            drivingProcessor = new DrivingProcessor(maxAcceleration);
            drivingInformationDisplay = new DrivingInformationDisplay(drivingProcessor);
            engine = new Engine(fuelTank);
            
        }

        public void BrakeBy(int speed)// car #2
            {
            drivingProcessor.ReduceSpeed(speed);
            
        }

        public void Accelerate(int speed) // car #2
           
            {
            if (engine.IsRunning)
            {
                drivingProcessor.IncreaseSpeedTo(speed);
                if (drivingProcessor.ActualSpeed == 0)engine.Consume(0.0003);
                else if (drivingProcessor.ActualSpeed <= 60 ) engine.Consume(0.0020);
                else if (drivingProcessor.ActualSpeed <= 100) engine.Consume(0.0014);
                else if (drivingProcessor.ActualSpeed <= 140) engine.Consume(0.0020);
                else if (drivingProcessor.ActualSpeed <= 200) engine.Consume(0.0025);
                else if (drivingProcessor.ActualSpeed <= 250) engine.Consume(0.0030);
            }
            }
         public void FreeWheel()  // car #2
            {
            drivingProcessor.ReduceSpeed(1);
            if (drivingProcessor.ActualSpeed == 0)engine.Consume(0.0003);
        } 

        public bool EngineIsRunning
        {
            get
            {
                return engine.IsRunning;
            }
        }

        public void EngineStart()
        {
            if ((!engine.IsRunning) && (fuelTank.FillLevel > 0))
            {
                engine.Start();
            }
        }

        public void EngineStop()
        {
            if (engine.IsRunning)
            {
                engine.Stop();
            }
        }

        public void Refuel(double liters)
        {
            fuelTank.Refuel(liters);
        }

        public void RunningIdle()
        {
            engine.Consume(0.0003);
        }
    }

    public class DrivingInformationDisplay : IDrivingInformationDisplay // car #2
    {
        private IDrivingProcessor _drivingProcessor;
        public DrivingInformationDisplay(IDrivingProcessor drivingProcessor)
        {
            _drivingProcessor=drivingProcessor;
        }
        
        public int ActualSpeed { get { return _drivingProcessor.ActualSpeed; } }
    }

    public class DrivingProcessor : IDrivingProcessor // car #2
    {
        private int _actualSpeed=0;
        private int _maxAcceleration;
        public DrivingProcessor ()
        {
            _maxAcceleration = 10;
        }

        public DrivingProcessor(int maxAcceleration)
        {
            if (maxAcceleration > 20) maxAcceleration = 20;
            if (maxAcceleration < 5) maxAcceleration = 5;
            _maxAcceleration = maxAcceleration;
        }
        public int ActualSpeed { get { return _actualSpeed; } }

        public void IncreaseSpeedTo(int speed)
        {
            if (speed <= _actualSpeed) { ReduceSpeed(1); return; }
            if (speed > 250) speed = 250;
            if (speed > _actualSpeed + _maxAcceleration) _actualSpeed += _maxAcceleration;
            else if (speed>_actualSpeed) _actualSpeed = speed;
        }

        public void ReduceSpeed(int speed)
        {
            if (speed < 0) return;
            if (speed > 10) speed = 10;
            if (_actualSpeed - speed < 0) _actualSpeed = 0;
            else _actualSpeed -= speed;

        }
    }


    public class Engine : IEngine
    {
        private bool _isRunning = false;

        private IFuelTank _fuelTank;

        public Engine(IFuelTank fuelTank)
        {
            _fuelTank = fuelTank;
        }

        public bool IsRunning
        {
            get
            {
                return _isRunning;
            }
        }

        public void Consume(double liters)
        {
            if (_isRunning)
            {
                _fuelTank.Consume(liters);
                if (_fuelTank.FillLevel == 0)
                {
                    Stop();
                }
            }
        }

        public void Start()
        {
            _isRunning = true;
        }

        public void Stop()
        {
            _isRunning = false;
        }
    }

    public class FuelTank : IFuelTank
    {
        private double _fillLevel;

        private double _tankSize = 60;

        public FuelTank()
        {
            _fillLevel = 20;
        }

        public FuelTank(double fillLevel)
        {
            if (fillLevel < 0)
            {
                fillLevel = 0;
            }
            if (fillLevel > _tankSize)
            {
                fillLevel = _tankSize;
            }

            _fillLevel = fillLevel;
        }

        public double FillLevel
        {
            get
            {
                return _fillLevel;
            }
        }

        public bool IsOnReserve
        {
            get
            {
                return _fillLevel < 5;
            }
        }

        public bool IsComplete
        {
            get
            {
                return _fillLevel == _tankSize;
            }
        }

        public void Consume(double liters)
        {
            _fillLevel -= liters;
            _fillLevel = Math.Round(_fillLevel, 10);

            if (_fillLevel < 0)
            {
                _fillLevel = 0;
            }
        }

        public void Refuel(double liters)
        {
            _fillLevel += liters;
            if (_fillLevel > 60)
            {
                _fillLevel = 60;
            }
        }
    }

    public class FuelTankDisplay : IFuelTankDisplay
    {
        private IFuelTank _fuelTank;

        public FuelTankDisplay(IFuelTank fuelTank)
        {
            _fuelTank = fuelTank;
        }

        public double FillLevel
        {
            get
            {
                return Math.Round(_fuelTank.FillLevel, 2);
            }
        }

        public bool IsOnReserve
        {
            get
            {
                return _fuelTank.IsOnReserve;
            }
        }

        public bool IsComplete
        {
            get
            {
                return _fuelTank.IsComplete;
            }
        }

    }
