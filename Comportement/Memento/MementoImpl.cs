using System.Collections.Generic;
namespace Memento
{
    public class MementoImpl:Memento
    {
        public IList<OptionVehicule> options = new List<OptionVehicule>();

        public IList<OptionVehicule> etat
        {
            get
            {
                return options;
            }
            set
            {
                this.options.Clear();
                foreach (var opt in value)
                    this.options.Add(opt);
            }
        }
        public MementoImpl()
        {
        }
    }
}
