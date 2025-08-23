using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns
{
    //Colleague interface (Airplane)

    public interface Airplane
    {
        void RequestTakeOff();
        void RequestLanding();
        void NotifyAirTrafficControl(String message);
    }

    //Concrete Colleague 
    public class CommercialAirplane : Airplane
    {
        private IAirTrafficControllerTower _mediator;
        public CommercialAirplane(IAirTrafficControllerTower mediator)
        {
            _mediator = mediator;
        }

        public void NotifyAirTrafficControl(string message)
        {
            Console.WriteLine("Commercial Airplane: " + message);
        }

        public void RequestLanding()
        {
            _mediator.RequestLanding(this);
        }

        public void RequestTakeOff()
        {
            _mediator.RequestTakeOff(this);
            
        }
    }
    //Mediator interface

    public interface IAirTrafficControllerTower
    {
        void RequestTakeOff(Airplane airplane);
        void RequestLanding(Airplane airplane);

    }

    //Concrete Mediator
    public class AirTrafficControllerTower : IAirTrafficControllerTower
    {
        public void RequestTakeOff(Airplane airplane)
        {
            airplane.NotifyAirTrafficControl("Requesting takeoff clearance");
        }

        public void RequestLanding(Airplane airplane)
        {
            airplane.NotifyAirTrafficControl("Requesting landing clearance");
        }
    }

} 
