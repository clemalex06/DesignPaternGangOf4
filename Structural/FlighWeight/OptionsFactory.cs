using System.Collections.Generic;
namespace FlighWeight
{
    public class OptionsFactory
    {
        public IDictionary<string, CarOption> options = new
            Dictionary<string, CarOption>();

        public CarOption getOption(string name)
        {
            CarOption result;

            if (options.ContainsKey(name))
            {
                result = options[name];
            }
            else
            {
                result = new CarOption(name);
                options.Add(name, result);
            }

            return result;
        }
    }
}
