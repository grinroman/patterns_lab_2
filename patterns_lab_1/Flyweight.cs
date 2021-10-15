using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace patterns_lab_1
{
   interface IReprository
    {
        void Create(string value);
        int Read(string value, bool last = false);

        string Read(int index);
    }

    class Reprository: IReprository
    {
        public static List<string> data;
        static Reprository() => data = new List<string>();
        public void Create(string value) => data.Add(value);

        public int Read(string value, bool last) =>
            last ? data.LastIndexOf(value) : data.IndexOf(value);
        public string Read(int index) => data[index];

    }

    class Emploee
    {
        private readonly IReprository repo;
        private int GetOrCreate(string characteristic)
        {
            int index =repo.Read(characteristic);

            if (index ==-1)
            {
                repo.Create(characteristic);
                return repo.Read(characteristic, true);
            }
            return index;
        }

        public Emploee(string fullinfo, IReprository reprository)
        {
            repo = reprository;
            characteristics = fullinfo.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(GetOrCreate).ToArray();
        }

        private readonly int[] characteristics;
        public override string ToString()=>String.Join(" ", characteristics.Select(e => repo.Read(e)));
    }
}
