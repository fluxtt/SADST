using System;

namespace SADST
{
    [Serializable]
    class MissionParameter
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Name + " = " + Value + ";"; 
        }
    }

}
