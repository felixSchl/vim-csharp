using System;
using System.Text;
using System.Collections.Generic;

namespace OrangeTentacle.Sample
{

    public interface IVehicle
    {
    }

    public enum Interesting
    {
    }

    public class Engine<IVehicle>
    {
    }

    public partial class Car : Bus, IVehicle
    {
        public string Name { get; set; }

        [Serialize]
        public string OtherName
        {
            get;
            set;
        }
        
        private Engine _engine;
        public Engine Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }

        public Car() : base()
        {
        }

        public void Run(List<Bob> bob, List<Bob> bob2)
        {
            var status = Engine.Start(x => x.Bob == true);
            int bob = 32;

            var hal = new List<Bob,List<Carl>> { Cal = 32; };
            var ral = new List<Bob,List<ICarl>> { Cal = 32; };

            List<Bob, List<ICarl>> list = new List<Bob, List<ICarl>> { Cal = 32 };

            var type = typeof(List<Bob, List<ICarl>>);

            var items = from e in db.Entities
                where e.Id == 1
                select e;

            var content = await RunAsync();

        }

        private async void RunAsync()
        {
        
        }
    }

}
