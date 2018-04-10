using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fly_up
{
    class Uart
    {
        String str;
        String start;
        Queue<Wave_Node> wave_queue = new Queue<Wave_Node>();
        List<Wave_Node> wave_list = new List<Wave_Node>();

        public  Uart(string start)
        {
            this.start = start;
        }

        public void set_str(string s)
        {
            str = s;
        }

        public void add_str_at_end(string s)
        {
            str += s;
        }

        public List<string> get_frams()
        {
            List<string> result;

            result = str.Split(start.ToCharArray()).ToList();
            str = result.Last();
            result.RemoveAt(result.Count() - 1);

            return result;
        }
        public Wave_Node frame_to_wave(string s)
        {
            int offset = 1;
            int frame_length = s[0];  //数据的字节长度，不包括CRC和帧头

            int data_num=frame_length/4;    //数字的个数，一个4字节
            if (frame_length % 4 != 0)
            {
                throw new Exception("no enough");
            }
            Wave_Node result = new Wave_Node();

            byte[] bytes = System.Text.Encoding.Default.GetBytes(s);

            float[] datas = new float[data_num];
            for (int i = 0; i < data_num; ++i)
            {
                float data = BitConverter.ToSingle(bytes, offset + i * 4);
                result.add(data);
            }

            return result;


        }

        public Wave_Node[]  analize(string s){
            List<string> frames=get_frams();
            Wave_Node[] result = new Wave_Node[frames.Count()];
            int i = 0;
            foreach (string frame in frames)
            {   
                result[i]=frame_to_wave(frame);
                i++;
            }
            return result;
        }
    }
}
