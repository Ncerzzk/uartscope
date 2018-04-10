using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fly_up
{
    class Wave_Node
    {
        List<float> data_buffer=new List<float>();
        public Wave_Node(float n1, float n2, float n3, float n4)
        {
            data_buffer.Add(n1);
            data_buffer.Add(n2);
            data_buffer.Add(n3);
            data_buffer.Add(n4);
        }
        public Wave_Node()
        {
        }
        public void add(float data)
        {
            data_buffer.Add(data);
        }

        public float get_ch(int ch_num)
        {
            if (data_buffer.Count() >= ch_num)
            {
                return data_buffer.ElementAt(ch_num - 1);
            }
            else
            {
                return 0;
            }
        }
        public int length()
        {
            return data_buffer.Count();
        }
        public float this[int index]{
            get{
                return data_buffer[index];
            }
            set
            {
                data_buffer[index]=value;
            }
        
        }
    }
}
